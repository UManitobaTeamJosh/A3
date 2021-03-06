﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Proj {
    public class Movie {

        private String title;
        private int year;
        private String length;
        private String director;
        private int rating;
        private List<String> genreList;
        private List<String> actorList;

        public Movie(String title, int year, String length, String director,
            int rating, List<String> genreList, List<String> actorList) {
            this.title = title;
            this.year = year;
            this.length = length;
            this.director = director;
            this.rating = rating;
            this.genreList = genreList;
            this.actorList = actorList;
        }

        /*
         *  Changes the rating of the movie. 
         *  A valid movie rating is
         *      >= 0
         *      <= 5
         *  
         *  Returns true if the rating was changed successfully.
         *  Returns false if the rating was unable to be changed.
         */
        public bool changeRating(int newRating) {
            bool output = false;
            if (newRating >= 0 && newRating <= 5) {
                output = true;
            }
            return output;
        }


        //Accessors
        public String getTitle() { return title; }
        public int getYear() { return year; }
        public String getLength() { return length; }
        public String getDirector() { return director; }
        public int getRating() { return rating; }
        public String[] getGenres() { return genreList.ToArray(); }
        public String[] getActors() { return actorList.ToArray(); }

        /*
         *  Produces a string representing the movie. The string is of the format
         *  Title Year Length Director Rating
         *      {Genre1,Genre2...}
         *      {Actor1,Actor2...}
         */
        public string toString() {
            String output = title + " " + year + " " + length + " " + director + " " + rating;
            output += "\n\t{";
            foreach (string genre in genreList) {
                output += genre + ",";
            }
            output += "}\n\t{";
            foreach (string actor in actorList) {
                output += actor + ",";
            }
            output += "}";
            return output;
        }
    }
}
