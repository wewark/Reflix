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
	public partial class HistoryForm : Form
	{
		public HistoryForm()
		{
			InitializeComponent();
		}

		private void HistoryForm_Load(object sender, EventArgs e)
		{
			var history = SQL.ReadQuery($@"select * from RENT where user_id = {Session.userID}");

			for (int i = 0; i < history.Count; i++)
			{
				// Get movie name
				var movie = SQL.ReadQuery($@"select movie_name from MOVIE where movie_id = {(int)history[i]["movie_id"]}");

				// Add to list
				string[] row = {
					movie[0]["movie_name"].ToString(),
					history[i]["start_date"].ToString(),
					history[i]["end_date"].ToString()
				};
				ListViewItem item = new ListViewItem(row);
				history_listView.Items.Add(item);
			}
		}
	}
}
