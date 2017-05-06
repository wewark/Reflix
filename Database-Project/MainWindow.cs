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
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{
			hello_label.Text = $"Hello, {Session.userFirstName}";
		}

		private void search_button_Click(object sender, EventArgs e)
		{
			SearchForm search = new SearchForm();
			search.Show();
		}

        private void update_button_Click(object sender, EventArgs e)
        {
            updateForm update = new updateForm();
            update.Show();
            hello_label.Text = $"Hello, {Session.userFirstName}";
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            ViewForm view = new ViewForm();
            view.Show();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            ReturnForm ret = new ReturnForm();
            ret.Show();
        }
    }
}
