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

                List<Dictionary<string, object>> users = SQL.ReadQuery($"SELECT * FROM [USER] WHERE user_username = '{userName}'");
                if (users.Count > 0 && userName != Session.username)
                {
                    err_msg = "Username already taken";
                    return false;
                }

                users = SQL.ReadQuery($"SELECT * FROM [USER] WHERE user_email = '{email}'");
                if (users.Count > 0 && email!= Session.email)
                {
                    err_msg = "Email already taken";
                    return false;
                }

                if (creditCard != "")
                {
                    users = SQL.ReadQuery($"SELECT * FROM [USER] WHERE user_creditcard = '{creditCard}'");
                    if (users.Count > 0 && creditCard!=Session.creditcard)
                    {
                        err_msg = "Credit Card already taken";
                        return false;
                    }
                }

                return true;
            }

            public void updateDB()
            {
               
              //  SQL.ChangeQuery("UPDATE [USER] VALUES " +date da ana shelto, sanyan hwa asln registration date, fa mlosh d3wa bl updata, mashe
              // yasta ma ana kont hashilo bas enta 2oltelo e3ml commit delw2ty fa wa2ft ya3niwwtvr okaa.y bas 3ash ya zmeeli walaahi
              /// sho3'l 3alee 
              /// rabna ya5lilna ramataak
              // kosom barmgeet visual studio
              /*
               * el db el gdeeda, lazm dymn el values, mynf3sh t7otha w 5alas, lazm t7ot esm kol column
               * b ma3na ?
               */
                //    $"('{userName}', '{password}', '{firstName}', '{lastName}', '{email}', '{creditCard}', '{date}')");

            }
        }
    }
}
