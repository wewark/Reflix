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
			movies = SQL.ReadQuery($@"
				select distinct movie.movie_id, movie_name, movie_year, director_name, movie_pricepermonth
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
		}

		private static List<Dictionary<string, object>> movies;

		// Adds a movie to the results table
		private void addRow(Dictionary<string, object> movie)
		{
			string[] movieData = new string[2] { movie["movie_name"].ToString(), movie["movie_year"].ToString() };
			result_listView.Items.Add(new ListViewItem(movieData));
		}

		private void rent_button_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < movies.Count; i++)
			{
				if (result_listView.Items[i].Checked)
					rentMovie(movies[i]);
			}
		}
		private void rentMovie(Dictionary<string, object> movie)
		{
			// Add the operation to RENT relation
			SQL.ChangeQuery($@"insert into RENT values
				({Session.userID}, {movie["movie_id"]}, {DateTime.Now.ToString("yyyy-MM-dd")}, {DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd")})");

			// Take the money
			Session.userBalance -= (double)movie["movie_pricepermonth"];
			SQL.ChangeQuery($@"update USERS set user_balance = {Session.userBalance} where user_id = {Session.userID}");
		}
	}
}
