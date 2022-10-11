using System;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{
    abstract class Movie : IMovie
    {
        private int id;
        private string name;
        private string kind;
        private string idFilm;
        private string director;
        private string filmClassification;
        private string filmAdaptation;
        private DateTime filmDuration;
        private DateTime releaseDate;
        private double imdbPoints;

        protected Movie(int id, string name, string kind, string idFilm, string director, string filmClassification, string filmAdaptation, DateTime filmDuration, DateTime releaseDate, double imdbPoints)
        {
            this.Id = id;
            this.Name = name;
            this.Kind = kind;
            this.IdFilm = idFilm;
            this.Director = director;
            this.FilmClassification = filmClassification;
            this.FilmAdaptation = filmAdaptation;
            this.FilmDuration = filmDuration;
            this.ReleaseDate = releaseDate;
            this.ImdbPoints = imdbPoints;
        }

        protected Movie()
        {
        }
        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Kind { get => kind; set => kind = value; }
        public string Director { get => director; set => director = value; }
        public string FilmClassification { get => filmClassification; set => filmClassification = value; }
        public string FilmAdaptation { get => filmAdaptation; set => filmAdaptation = value; }
        public DateTime FilmDuration { get => filmDuration; set => filmDuration = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string IdFilm { get => idFilm; set => idFilm = value; }
        public double ImdbPoints { get => imdbPoints; set => imdbPoints = value; }
        
        public void AddFilm()
        {
            throw new NotImplementedException();
        }

        public void ViewListFilm()
        {
            throw new NotImplementedException();
        }

        public void SearchFilmByID(string search)
        {
            throw new NotImplementedException();
        }

        public void DeleteFilmByID(string s)
        {
            throw new NotImplementedException();
        }

        public void UpdateFilmByID(string s)
        {
            throw new NotImplementedException();
        }

        public void SoftFilmByID()
        {
            throw new NotImplementedException();
        }
    }
}