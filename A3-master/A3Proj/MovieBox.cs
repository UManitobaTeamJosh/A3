using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Proj {
    public partial class MovieBox : UserControl {

        private Movie movie;

        public MovieBox() {
            InitializeComponent();
        }

        public MovieBox(Movie movie)
            : this() {
            this.movie = movie;
            this.labelMovieTitle.Text = movie.getTitle();
            this.labelMovieYear.Text = movie.getYear().ToString();
            //Figure out how to display ratings.
        }
    }
}
