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
    public partial class DataTesting : Form {

        private static readonly String FILE_NAME = "movies.xml";

        public DataTesting() {
            InitializeComponent();
            loadXML();
            //Console.WriteLine("Done loading");
        }

        private void loadXML() {
            if (System.IO.File.Exists(FILE_NAME)) {
                XDocument xmlSource = XDocument.Load("moviesShort.xml");
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
                foreach (Movie movie in movieList) {
                    Console.WriteLine(movie.toString());
                }
            } else {
                MessageBox.Show("xmlSource.xml not found. No data loaded.");
            }
            //Do something with data, like populate a table
        }//loadXML


    }//class
}
