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
	public partial class ReturnForm : Form
	{
		public ReturnForm()
		{
			InitializeComponent();
		}

        private void ReturnForm_Load(object sender, EventArgs e)
        {
            movies = SQL.ReadQuery($@"
                        select distinct movie.movie_id , movie_name, movie_year, director_name, movie_pricepermonth
                        from MOVIE
                             join DIRECTOR on MOVIE.director_id = DIRECTOR.director_id
					         join ACTS on MOVIE.movie_id = ACTS.movie_id
					         join ACTOR on ACTOR.actor_id = ACTS.actor_id
                        Where MOVIE.movie_id = 
                      ( select RENT.movie_id
                        from RENT
                        Where RENT.user_id = '{Session.userID}' )
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

        private void return_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < movies.Count; i++)
            {
                if (result_listView.Items[i].Checked)
                    returnMovie(movies[i]);
            }
        }

        private void returnMovie(Dictionary<string, object> movie)
        {
            // delete from rent table
            SQL.ChangeQuery($@"DELETE from RENT WHERE (RENT.user_id = '{Session.userID}' && Rent.movie_id = ' {movie["movie_id"]}') ");

        }
    }
}
