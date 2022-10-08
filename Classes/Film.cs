using System;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{
    public class Film : IFilm
    {
        private string id;
        private string kind;
        private string director;
        private string filmClassification;
        private string filmAdaptation;
        private string review;
        private DateTime filmDuration;
        private DateTime releaseDate;
        private double imdbPoints;

        public Film(string id, string kind, string director, string filmClassification, string filmAdaptation, string review, DateTime filmDuration, DateTime releaseDate, double imdbPoints)
        {
            this.Id = id;
            this.Kind = kind;
            this.Director = director;
            this.FilmClassification = filmClassification;
            this.FilmAdaptation = filmAdaptation;
            this.Review = review;
            this.FilmDuration = filmDuration;
            this.ReleaseDate = releaseDate;
            this.ImdbPoints = imdbPoints;
        }

        public string Id { get => id; set => id = value; }
        public string Kind { get => kind; set => kind = value; }
        public string Director { get => director; set => director = value; }
        public string FilmClassification { get => filmClassification; set => filmClassification = value; }
        public string FilmAdaptation { get => filmAdaptation; set => filmAdaptation = value; }
        public DateTime FilmDuration { get => filmDuration; set => filmDuration = value; }
        public string Review { get => review; set => review = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public double ImdbPoints { get => imdbPoints; set => imdbPoints = value; }
    }
}