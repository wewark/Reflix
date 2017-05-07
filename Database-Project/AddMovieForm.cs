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
	public partial class AddMovieForm : Form
	{
		public AddMovieForm()
		{
			InitializeComponent();
		}

		struct Movie
		{
			public string name { get; set; }
			public int year { get; set; }
			public string category { get; set; }
			public int directorID { get; set; }
			public int actor1ID { get; set; }
			public int actor2ID { get; set; }
			public double price { get; set; }
		}

		private void add_button_Click(object sender, EventArgs e)
		{
			// If any important info is empty
			if (name_textBox.Text == "" ||
				year_textBox.Text == "" ||
				category_textBox.Text == "" ||
				director_textBox.Text == "" ||
				actor1_textBox.Text == "" ||
				price_textBox.Text == "")
			{
				err_label.Text = "Please fill all the info";
				return;
			}

			Movie movie = new Movie()
			{
				name = name_textBox.Text,
				year = Convert.ToInt32(year_textBox.Text),
				category = category_textBox.Text,
				price = Convert.ToDouble(price_textBox.Text)
			};

			var actor = SQL.ReadQuery($@"select * from ACTOR
				where actor_name = '{actor1_textBox.Text}'");
			// If actor1 isn't in the database
			if (actor.Count == 0)
			{
				SQL.ChangeQuery($@"insert into ACTOR values ('{actor1_textBox.Text}')");
				actor = SQL.ReadQuery($@"select * from ACTOR
					where actor_name = '{actor1_textBox.Text}'");
			}
			movie.actor1ID = (int)actor[0]["actor_id"];

			// Actor2 is optional
			if (actor2_textBox.Text != "")
			{
				actor = SQL.ReadQuery($@"select * from ACTOR
				where actor_name = '{actor2_textBox.Text}'");
				// If actor2 isn't in the database
				if (actor.Count == 0)
				{
					SQL.ChangeQuery($@"insert into ACTOR values ('{actor2_textBox.Text}')");
					actor = SQL.ReadQuery($@"select * from ACTOR
						where actor_name = '{actor1_textBox.Text}'");
				}
				movie.actor2ID = (int)actor[0]["actor_id"];
			}

			var director = SQL.ReadQuery($@"select * from DIRECTOR
				where director_name = '{director_textBox.Text}'");
			// If the director isn't in the database
			if (director.Count == 0)
			{
				SQL.ChangeQuery($@"insert into DIRECTOR values ('{director_textBox.Text}')");
				director = SQL.ReadQuery($@"select * from DIRECTOR
					where director_name = '{director_textBox.Text}'");
			}
			movie.directorID = (int)director[0]["director_id"];

			// Everything done, movie now holds all the movie data
			// Add the movie to the database
			SQL.ChangeQuery($@"insert into MOVIE values
				({movie.directorID}, {Session.adminID}, '{movie.name}', {movie.year},
				'{movie.category}', {movie.price}, 10)");

			// Select the movie again to get its ID
			var insertedMovie = SQL.ReadQuery($"select movie_id from MOVIE where movie_name = '{movie.name}'")[0];

			// Connect actor1 and the movie through the relation ACTS
			SQL.ChangeQuery($@"insert into ACTS values
				({insertedMovie["movie_id"]}, {movie.actor1ID})");

			if (actor2_textBox.Text != "")
			{
				// Connect actor2 and the movie through the relation ACTS
				SQL.ChangeQuery($@"insert into ACTS values
				({insertedMovie["movie_id"]}, {movie.actor2ID})");
			}

			// Close window
			Close();
		}

		private void AddMovieForm_Load(object sender, EventArgs e)
		{
			err_label.Text = "";
		}
	}
}
