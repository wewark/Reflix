using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Global;

namespace Database_Project
{

	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			//List<Dictionary<string,object>> res = sql.ReadQuery("select * from ACTS");
		}

		private void login_button_Click(object sender, EventArgs e)
		{
           // Verify password
            List<Dictionary<string, object>> users = sql.ReadQuery($"SELECT * FROM [USER] WHERE user_username = '{username_textBox.Text}'");

			err_label.Text = "";
			// If user not found
			if (users.Count == 0)
			{
				err_label.Text = "Wrong username";
			}
			// If wrong password
			else if (users[0]["user_password"].ToString() != password_textBox.Text)
			{
				err_label.Text = "Wrong password";
			}
			// Everything good
			else
			{
				// TODO: load main window
			}
        }

		private void register_button_Click(object sender, EventArgs e)
		{
			// Show registration form
			RegisterForm regForm = new RegisterForm();
			regForm.Show();
		}
	}
}
