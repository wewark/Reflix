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
    public partial class updateForm : Form
    {
        public updateForm()
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

                List<Dictionary<string, object>> users = SQL.ReadQuery($"SELECT * FROM [USERS] WHERE user_username = '{userName}'");
                if (users.Count > 0 && userName != Session.username)
                {
                    err_msg = "Username already taken";
                    return false;
                }

                users = SQL.ReadQuery($"SELECT * FROM [USERS] WHERE user_email = '{email}'");
                if (users.Count > 0 && email != Session.email)
                {
                    err_msg = "Email already taken";
                    return false;
                }

                if (creditCard != "")
                {
                    users = SQL.ReadQuery($"SELECT * FROM [USERS] WHERE user_creditcard = '{creditCard}'");
                    if (users.Count > 0 && creditCard != Session.creditcard)
                    {
                        err_msg = "Credit Card already taken";
                        return false;
                    }
                }

                return true;
            }

            public void updateDB()
            {

                SQL.ChangeQuery($@"UPDATE USERS
					SET user_username = '{userName}', user_password ='{password}', user_firstname = '{firstName}', user_lastname = '{lastName}', user_email = '{email}',
                      user_creditcard = '{creditCard}'
                     WHERE user_id = '{Session.userID}';");

            }


        }

        private void update_button_1_Click(object sender, EventArgs e)
        {
            if(confirm_textBox1.Text!=password_textBox1.Text)
            {
                err.Text= "Password and confirmation don't match";
                return;
            }

            User user = new User
            {
                firstName = firstName_textBox1.Text,
                lastName = lastName_textBox1.Text,
                userName = username_textBox1.Text,
                password = password_textBox1.Text,
                email = email_textBox1.Text,
                creditCard = creditCard_textBox1.Text

            };

            if (user.validate())
            {
                user.updateDB();
                Session.userFirstName = user.firstName;
                Session.userlastname = user.lastName;
                Session.username = user.userName;
                Session.password = user.password;
                Session.email = user.email;
                Session.creditcard = user.creditCard;
                Close();
            }
        }
    }
}
