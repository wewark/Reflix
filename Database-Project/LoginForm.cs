﻿using System;
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

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// TODO: login
		}

		private void register_button_Click(object sender, EventArgs e)
		{
			// Show registration form
			RegisterForm regForm = new RegisterForm();
			regForm.Show();
		}
	}
}