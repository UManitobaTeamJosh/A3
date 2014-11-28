using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace A3Proj {
    public partial class Form1 : Form {

        private static readonly String FILE_NAME = "movies.xml";
        private List<Movie> movieList = new List<Movie>();
        private int pageTableCapacity = 200;

        public Form1() {
            InitializeComponent();
            loadXML();
            populateTable();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        /*
         *  Populate the current page with the relevant movie data.
         */
        private void populateTable() {
            //movieTableLayout.Controls.Add(new MovieBox(movieList[0]));
            //movieTableLayout.Controls.Add(new MovieBox(movieList[1]));
            for (int i = 0; i < pageTableCapacity; i++) {
                if (i < movieList.Count) {
                    //movieTableLayout.Controls.Add(new MovieBox(movieList[i]));
                    movieFlowPanel.Controls.Add(new MovieBox(movieList[i]));
                }
            }
        }

        private void loadXML() {
            if (System.IO.File.Exists(FILE_NAME)) {
                XDocument xmlSource = XDocument.Load("movies.xml");
                IEnumerable<XElement> items = xmlSource.Descendants("movie");
                List<Movie> movieList = new List<Movie>();
                foreach (var p in items) {
                    IEnumerable<XElement> elementItems = p.Descendants();
                    int eIndex = 0;
                    String name = null;
                    int year = -1;
                    String length = null;
                    //certification
                    String director = null;
                    int rating = -1;
                    List<string> genres = new List<string>();
                    List<string> actors = new List<string>();
                    foreach (var p2 in elementItems) {
                        String elementName = p2.Name.ToString();
                        //Console.WriteLine(eIndex+" - "+elementName+"\t-\t"+p2.Value);
                        switch (elementName) {
                            case "title":
                                name = p2.Value;
                                break;
                            case "year":
                                year = Convert.ToInt32(p2.Value);
                                break;
                            case "length":
                                length = p2.Value;
                                break;
                            case "certification":
                                //Unused
                                break;
                            case "director":
                                director = p2.Value;
                                break;
                            case "rating":
                                rating = Convert.ToInt32(p2.Value);
                                break;
                            case "genre":
                                genres.Add(p2.Value);
                                break;
                            case "actor":
                                actors.Add(p2.Value);
                                break;
                        }
                        eIndex++;
                    }//foreach subelement
                    Movie movie = new Movie(name, year, length, director, rating, genres, actors);
                    movieList.Add(movie);
                }//foreach descendant
                //Done loading movies. Do something with movielist now.
                /*
                foreach (Movie movie in movieList) {
                    Console.WriteLine(movie.toString());
                }
                */
                this.movieList = movieList;
            } else {
                MessageBox.Show("xmlSource.xml not found. No data loaded.");
            }
            //Do something with data, like populate a table
        }//loadXML

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
