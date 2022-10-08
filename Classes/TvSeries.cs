using System;
using System.Collections.Generic;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{
    public class TvSeries: ITvSeries
    {
        private string id;
        private string kind;
        private string director;
        private string filmClassification;
        private string filmAdaptation;
        private string review;
        private DateTime releaseDate;
        private double imdbPoints;
        private List<IMovie> season;

        public string Id { get => id; set => id = value; }
        public string Kind { get => kind; set => kind = value; }
        public string Director { get => director; set => director = value; }
        public string FilmClassification { get => filmClassification; set => filmClassification = value; }
        public string FilmAdaptation { get => filmAdaptation; set => filmAdaptation = value; }
        public string Review { get => review; set => review = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public double ImdbPoints { get => imdbPoints; set => imdbPoints = value; }
        public List<IMovie> Season { get => season; set => season = value; }
        
        
    }
}