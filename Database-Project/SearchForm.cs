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
	public partial class SearchForm : Form
	{
		public SearchForm()
		{
			InitializeComponent();
		}

		private void search_button_Click(object sender, EventArgs e)
		{
			/*
			 * Most of the searches will use this query
				select *
				from MOVIE
				join DIRECTOR on MOVIE.director_id = DIRECTOR.director_id
				join ACTS on MOVIE.movie_id = ACTS.movie_id
				join ACTOR on ACTOR.actor_id = ACTS.actor_id
				where movie_year = 2010
			 */

			string searchQuery = search_textBox.Text;
			var movies = SQL.ReadQuery($@"
				select distinct movie_name, movie_year, director_name
				from MOVIE
					join DIRECTOR on MOVIE.director_id = DIRECTOR.director_id
					join ACTS on MOVIE.movie_id = ACTS.movie_id
					join ACTOR on ACTOR.actor_id = ACTS.actor_id
				where
					movie_name like '%{searchQuery}%' or
					actor_name like '%{searchQuery}%' or
					director_name like '%{searchQuery}%'
			");

			// Show results in the table
			foreach (var movie in movies)
			{
				addRow(movie);
			}
			result_tableLayoutPanel.RowCount++;
		}

		// Adds a movie to the results table
		private void addRow(Dictionary<string, object> movie)
		{
			result_tableLayoutPanel.RowCount++;
			result_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

			result_tableLayoutPanel.Controls.Add(new Label() {
				Text = movie["movie_name"].ToString(),
				TextAlign = ContentAlignment.MiddleCenter,
				Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)
			}, 0, result_tableLayoutPanel.RowCount - 1);

			result_tableLayoutPanel.Controls.Add(new Label() {
				Text = movie["movie_year"].ToString(),
				TextAlign = ContentAlignment.MiddleCenter,
				Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)
			}, 1, result_tableLayoutPanel.RowCount - 1);

			result_tableLayoutPanel.Controls.Add(new Label() {
				Text = movie["director_name"].ToString(),
				TextAlign = ContentAlignment.MiddleCenter,
				Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)
			}, 2, result_tableLayoutPanel.RowCount - 1);
		}
	}
}
