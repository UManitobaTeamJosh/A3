﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Proj {
    /*
     * TODO Use auto ellipsize instead of manual code
     */
    public partial class MovieBox : UserControl {

        private static readonly int ELLIPSIZE_LIMIT = 22;

        private Movie movie;

        public MovieBox() {
            InitializeComponent();
        }

        public MovieBox(Movie movie) : this() {
            this.movie = movie;
            this.labelMovieYear.Text = movie.getYear().ToString();
            
            setToolTips(movie.getTitle());
            setTitle(movie.getTitle());
        }

        /*
         * Sets the tooltip for MovieBox itself and all of its child controls.
         * Tooltip is set dynamically, so cannot be defined in Designer.cs
         */
        private void setToolTips(string text) {
            this.toolTip1.SetToolTip(this, movie.getTitle());
            foreach (Control control in this.Controls) {
                this.toolTip1.SetToolTip(control, text);
            }
        }

        private void setRatings() {

        }

        /*
         *  Sets the title of the film.
         *  If the length exceeds the ELLIPSIZE_LIMIT then it is truncated 
         *  with a "..." representing the missing characters.
         */
        private void setTitle(string title) {
            if (title.Length > ELLIPSIZE_LIMIT) {
                title = title.Substring(0,ELLIPSIZE_LIMIT-1);
                title += "...";
            }
            this.labelMovieTitle.Text = title;
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
