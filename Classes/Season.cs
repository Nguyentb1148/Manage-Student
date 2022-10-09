using System;
using System.Collections.Generic;
using ManageMovie.Interface;

namespace ManageMovie.Classes
{
    public class Season: IMovie
    {
        private static List<Film> listEpisodes = new List<Film>();
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
        public Season(int id, string name, string kind, string idFilm, string director, string filmClassification, string filmAdaptation, DateTime filmDuration, DateTime releaseDate, double imdbPoints)
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
        public Season()
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

        public void AddEpisodes()
        {
            Film season = new Film();
            
            season.Id = listEpisodes.Count + 1;
            //Input Id film
            Console.Write("Enter Film id: ");
            season.IdFilm = Console.ReadLine();
            //Input Name of film
            Console.Write("Enter Name : ");
            season.Name = Console.ReadLine();
            //Input Kind
            Console.Write("Enter Kind of Film: ");
            season.Kind = Console.ReadLine();
            //Input Dicertor
            Console.Write("Enter Director of film: ");
            season.Director = Console.ReadLine();
            //Input Film classification
            Console.Write("Enter Film Classification: ");
            season.FilmClassification = Console.ReadLine();
            //Input film adaptation
            Console.Write("Enter Film Adaption: ");
            season.FilmAdaptation = Console.ReadLine();
            //Input Film duration
            Console.Write("Enter Film Duration: ");
            season.FilmDuration = DateTime.Parse(Console.ReadLine());
            //Input Release date
            Console.Write("Enter Film  Release Date: ");
            season.ReleaseDate = DateTime.Parse(Console.ReadLine());
            //Input Imdb points
            Console.Write("Enter Imdb points: ");
            season.ImdbPoints = double.Parse(Console.ReadLine());
            //Add to list film
            listEpisodes.Add(season);
            Console.WriteLine("Successfully inserted");
        }

        public void ViewListEpisodes()
        {
            var table = new Table();

            table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");

            foreach (Film i in listEpisodes)
            {
                table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.ImdbPoints.ToString());
            }
            Console.WriteLine(table.ToString());
        }
    }
}