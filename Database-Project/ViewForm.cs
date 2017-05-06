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
	public partial class ViewForm : Form
	{
		public ViewForm()
		{
			InitializeComponent();
		}

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reflixDataSet1.USERS' table. You can move, or remove it, as needed.
            movies = SQL.ReadQuery($@"
                        select distinct movie.movie_id, movie_name, movie_year, director_name, movie_pricepermonth
                        from MOVIE
                            join DIRECTOR on MOVIE.director_id = DIRECTOR.director_id
                            join ACTS on MOVIE.movie_id = ACTS.movie_id
                            join ACTOR on ACTOR.actor_id = ACTS.actor_id
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


       

    }
}
