using System;
using System.Collections.Generic;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{
    public class TvSeries: ITvSeries
    { 
        private static List<TvSeries> listTvSeries = new List<TvSeries>();
        private int id;
        private string name;
        private string idFilm;
        private string kind;
        private string director;
        private string filmClassification;
        private string filmAdaptation;
        private DateTime filmDuration;
        private DateTime releaseDate;
        private double imdbPoints;
        private List<Season> season;
        public TvSeries()
        {
            
        }

        public void AddTvSerie()
        {
            listTvSeries.Add(new TvSeries(1,"John Wich","F001","Action","Chad Stahelski", "R","Null",DateTime.Parse("01:41:00"),DateTime.Parse("10/24/2014"),7.4,new List<Season>(id)));
            listTvSeries.Add(new TvSeries(2,"John Wick: Chapter 2","F002","Action","Chad Stahelski", "R","Null",DateTime.Parse("02:02:00"),DateTime.Parse("02/10/2017"),7.4,new List<Season>(id)));
            listTvSeries.Add(new TvSeries(3,"John Wick: Chapter 3 - Parabellum","F003","Action","Chad Stahelski", "R","Null",DateTime.Parse("02:10:00"),DateTime.Parse("05/17/2019"),7.4,new List<Season>(id)));
            listTvSeries.Add(new TvSeries(4,"The Fellowship of the Ring","F004","Action,Adventure","Peter Jackson", "PG-13","novels",DateTime.Parse("02:58:00"),DateTime.Parse("12/19/2001"),7.4,new List<Season>(id)));
        }

        public TvSeries(int id, string name, string idFilm, string kind, string director, string filmClassification, string filmAdaptation, DateTime filmDuration, DateTime releaseDate, double imdbPoints, List<Season> season)
        {
            this.Id = id;
            this.Name = name;
            this.IdFilm = idFilm;
            this.Kind = kind;
            this.Director = director;
            this.FilmClassification = filmClassification;
            this.FilmAdaptation = filmAdaptation;
            this.FilmDuration = filmDuration;
            this.ReleaseDate = releaseDate;
            this.ImdbPoints = imdbPoints;
            this.Season = season;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Kind { get => kind; set => kind = value; }
        public string Director { get => director; set => director = value; }
        public string FilmClassification { get => filmClassification; set => filmClassification = value; }
        public string FilmAdaptation { get => filmAdaptation; set => filmAdaptation = value; }
        public DateTime FilmDuration { get => filmDuration; set => filmDuration = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public double ImdbPoints { get => imdbPoints; set => imdbPoints = value; }
        public string IdFilm { get => idFilm; set => idFilm = value; }
        public List<Season> Season { get => season; set => season = value; }
        
          public void AddTvSeries()
        {
            TvSeries tvSeries = new TvSeries();
            
            tvSeries.Id = listTvSeries.Count + 1;
            //Input Id film
            Console.Write("Enter Film id: ");
            tvSeries.IdFilm = Console.ReadLine();
            //Input Name of film
            Console.Write("Enter Name : ");
            tvSeries.Name = Console.ReadLine();
            //Input Kind
            Console.Write("Enter Kind of Tv Series: ");
            tvSeries.Kind = Console.ReadLine();
            //Input Dicertor
            Console.Write("Enter Director of Tv Series: ");
            tvSeries.Director = Console.ReadLine();
            //Input Film classification
            Console.Write("Enter Tv Series Classification: ");
            tvSeries.FilmClassification = Console.ReadLine();
            //Input film adaptation
            Console.Write("Enter Tv Series Adaption: ");
            tvSeries.FilmAdaptation = Console.ReadLine();
            //Input Film duration
            Console.Write("Enter Tv Series Duration: ");
            tvSeries.FilmDuration = DateTime.Parse(Console.ReadLine());
            //Input Release date
            Console.Write("Enter Tv Series  Release Date: ");
            tvSeries.ReleaseDate = DateTime.Parse(Console.ReadLine());
            //Input Imdb points
            Console.Write("Enter Imdb points: ");
            tvSeries.ImdbPoints = double.Parse(Console.ReadLine());
            //Add to list film
            listTvSeries.Add(tvSeries);
            Console.WriteLine("Successfully inserted Tv Series");
        }

        public void ViewListTvSeries()
        {
            var table = new Table();

            table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");

            foreach (TvSeries i in listTvSeries)
            {
                table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.ImdbPoints.ToString());
            }
            Console.WriteLine(table.ToString());
        }
        
    }
}