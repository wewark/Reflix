using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Global;

namespace Database_Project
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		struct User
		{
			public string firstName;
			public string lastName;
			public string userName;
			public string password;
			public string email;
			public string creditCard;

			public string err_msg;

			// Returns false if anything was taken before
			public bool validate()
			{
				if (firstName == "" || userName == "" || password == "" || email == "")
				{
					err_msg = "Please fill the mandatory data";
					return false;
				}

				List<Dictionary<string, object>> users = sql.ReadQuery($"SELECT * FROM [USER] WHERE user_username = '{userName}'");
				if (users.Count > 0)
				{
					err_msg = "Username already taken";
					return false;
				}

				users = sql.ReadQuery($"SELECT * FROM [USER] WHERE user_email = '{email}'");
				if (users.Count > 0)
				{
					err_msg = "Email already taken";
					return false;
				}

				if (creditCard != "")
				{
					users = sql.ReadQuery($"SELECT * FROM [USER] WHERE user_creditcard = '{creditCard}'");
					if (users.Count > 0)
					{
						err_msg = "Credit Card already taken";
						return false;
					}
				}

				return true;
			}
			public void addToDB()
			{
				string date = DateTime.Now.ToString();
				sql.ChangeQuery($"INSERT INTO [USER] VALUES " +
					$"('{userName}', '{password}', '{firstName}', '{lastName}', '{email}', '{creditCard}', '{date}')");
				
			}
		}

		private void register_button_Click(object sender, EventArgs e)
		{
			if (confirm_textBox.Text != password_textBox.Text)
			{
				err_label.Text = "Password and confirmation don't match";
				return;
			}

			User user = new User
			{
				firstName = firstName_textBox.Text,
				lastName = lastName_textBox.Text,
				userName = username_textBox.Text,
				password = password_textBox.Text,
				email = email_textBox.Text,
				creditCard = creditCard_textBox.Text
			};

			// If everything is valid
			if (user.validate())
			{
				user.addToDB();
				// TODO: show main window

				// Close current window (login window)
				Close();
			}
			else
			{
				err_label.Text = user.err_msg;
				return;
			}
		}
	}
}
