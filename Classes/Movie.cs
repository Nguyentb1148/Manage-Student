using System;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{
    abstract class Movie : IMovie
    {
        private string id;
        private string kind;
        private string director;
        private string filmClassification;
        private string filmAdaptation;
        private string review;
        private DateTime releaseDate;
        private double imdbPoints;

        protected Movie(string id, string kind, string director, string filmClassification, string filmAdaptation, string review, DateTime releaseDate, double imdbPoints)
        {
            this.id = id;
            this.kind = kind;
            this.director = director;
            this.filmClassification = filmClassification;
            this.filmAdaptation = filmAdaptation;
            this.review = review;
            this.releaseDate = releaseDate;
            this.imdbPoints = imdbPoints;
        }

        public string Id { get => id; set => id = value; }
        public string Kind { get => kind; set => kind = value; }
        public string Director { get => director; set => director = value; }
        public string FilmClassification { get => filmClassification; set => filmClassification = value; }
        public string FilmAdaptation { get => filmAdaptation; set => filmAdaptation = value; }
        public string Review { get => review; set => review = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public double ImdbPoints { get => imdbPoints; set => imdbPoints = value; }
    }
}