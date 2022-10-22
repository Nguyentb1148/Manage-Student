using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using ManageMovie.Interface;
using Microsoft.SqlServer.Server;

namespace ManageMovie.Classes
{
    public class Film : IMovie
    {
        private static List<Film> listFilms = new List<Film>();
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
        
        // public through get set
        public static List<Film> ListFilms
        {
            get { return listFilms; }
            set { listFilms = value; }
        }
        
        public Film(int id, string name, string idFilm, string kind, string director, string filmClassification, string filmAdaptation, DateTime filmDuration, DateTime releaseDate, double imdbPoints)
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
        }

        //"No", "ID Film", "Name", "Kind", "Director", "Film Classification","Film Adaptation","Film Duration", "Film Release Date","Imdb point","Review"
        public void FilmAdd()
        {
            listFilms.Add(new Film(1,"John Wich","F001","Action","Chad Stahelski", "R","Null",DateTime.Parse("01:41:00"),DateTime.Parse("10/24/2014"),7.4));
            listFilms.Add(new Film(2,"John Wick: Chapter 2","F002","Action","Chad Stahelski", "R","Null",DateTime.Parse("02:02:00"),DateTime.Parse("02/10/2017"),7.4));
            listFilms.Add(new Film(3,"John Wick: Chapter 3 - Parabellum","F003","Action","Chad Stahelski", "R","Null",DateTime.Parse("02:10:00"),DateTime.Parse("05/17/2019"),7.4));
            listFilms.Add(new Film(4,"The Fellowship of the Ring","F004","Action,Adventure","Peter Jackson", "PG-13","novels",DateTime.Parse("02:58:00"),DateTime.Parse("12/19/2001"),7.4));
        }

        public Film()
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
        public double ImdbPoints { get => imdbPoints; set => imdbPoints = value; }
        public string IdFilm { get => idFilm; set => idFilm = value; }

        public void AddFilm()
        {
            Film film = new Film();
            //Increment Id
            film.Id = listFilms.Count + 1;
            InputIdFlim:
            //Input Name of film
            Console.Write("Enter ID film : ");
            film.IdFilm = Console.ReadLine();
            foreach (Film iFilm in listFilms)
            {
                if (iFilm.IdFilm.Equals(film.IdFilm))
                {
                    Console.WriteLine("This id already exists");
                    goto InputIdFlim;
                }
            }
            //Input Name of film
            Console.Write("Enter Name : ");
            film.Name = Console.ReadLine();
            //Input Kind
            Console.Write("Enter Kind of Film: ");
            film.Kind = Console.ReadLine();
            //Input Director
            Console.Write("Enter Director of film: ");
            film.Director = Console.ReadLine();
            //Input Film classification
            Console.WriteLine("--------------MPA film ratings-------------");
            Console.WriteLine("|1:G – General Audiences                  |");
            Console.WriteLine("|2:PG – Parental Guidance Suggested       |");
            Console.WriteLine("|3:PG-13 – Parents Strongly Cautioned     |");
            Console.WriteLine("|4:R – Restricted                         |");
            Console.WriteLine("|5:NC-17 – Adults Only                    |");
            Console.WriteLine("|6:Other                                  |");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Film Classification: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    film.FilmClassification = "G";
                    break;
                case 2:
                    film.FilmClassification = "PG";
                    break;
                case 3:
                    film.FilmClassification = "PG-13";
                    break;
                case 4:
                    film.FilmClassification = "R";
                    break;
                case 5:
                    film.FilmClassification = "NR-17";
                    break;
                case 6:
                    
                    film.FilmClassification = Console.ReadLine();
                    break;
            }

            //Input Film Adaptation
            Console.WriteLine("--------------Adaptation film -------------");
            Console.WriteLine("|1:Book adaptations                       |");
            Console.WriteLine("|2:Comic book adaptations                 |");
            Console.WriteLine("|3:Musical adaptations                    |");
            Console.WriteLine("|4:Play adaptations                       |");
            Console.WriteLine("|5:Television adaptations                 |");
            Console.WriteLine("|6:Video game adaptations                 |");
            Console.WriteLine("|7.Other                                  |");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Film Classification: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    film.filmAdaptation = "Book";
                    break;
                case 2:
                    film.filmAdaptation = "Comic book";
                    break;
                case 3:
                    film.filmAdaptation = "Musical";
                    break;
                case 4:
                    film.filmAdaptation = "Play";
                    break;
                case 5:
                    film.filmAdaptation = "Television";
                    break;
                case 6:
                    film.filmAdaptation = "Video game";
                    break;
                case 7:
                    Console.Write("Input the source to be adapted: ");
                    film.filmAdaptation = Console.ReadLine();
                    break;
            }
            InputFilmDuration:
            //Input Film duration
            string[] formatTimes= {"h:mm:ss","hh:mm:ss","h:m:s","mm:ss","m:ss","mm:s","h","hh","h:mm",} ;
            Console.Write("Enter Film Duration: ");
            string filmDurationTime = Console.ReadLine();
            DateTime dateValue;
       
            try
            {
                if (DateTime.TryParseExact(filmDurationTime, formatTimes, new CultureInfo("en-US"),
                        DateTimeStyles.None, out dateValue))
                {
                    film.FilmDuration = DateTime.Parse(filmDurationTime);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong");
                goto InputFilmDuration;
            }

            InputFilmReleaseTime:
            DateTime dateValue2;
            string[] formatDateTime= {"dd/mm/yyyy","d/m/yyyy","dd/m/yyyy","d/mm/yyyy" };
            Console.Write("Enter Film Release Time: ");
            string filmReleaseTime = Console.ReadLine();
            //Input Release date
            try
            {
                DateTime parsedDateTime;
                if (DateTime.TryParseExact(filmReleaseTime, formatDateTime, new CultureInfo("en-US"),
                        DateTimeStyles.None, out parsedDateTime))
                {
                    film.ReleaseDate = DateTime.Parse(filmReleaseTime);
                }
                else
                {
                    goto InputFilmReleaseTime;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The date is not in the correct format!");
                Console.WriteLine("Should be dd/mm/yyyy"); 
                goto InputFilmReleaseTime;
            }

            InputImDbPoints:
            //Input Imdb points
            Console.Write("Enter Imdb points: ");
            film.ImdbPoints = double.Parse(Console.ReadLine());
            if (film.ImdbPoints > 10)
            {
                Console.WriteLine("ImdbPoints cannot greater than 10");
                goto  InputImDbPoints;
            }
            //Add to list film
            listFilms.Add(film);
            Console.WriteLine("Successfully inserted");
        }
     
        public void ViewListFilm()
        {
            var table = new Table();

            table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");

            foreach (Film i in listFilms)
            {
                table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.ImdbPoints.ToString());
            }
            Console.WriteLine(table.ToString());
            
        }

        public void SearchFilmByID(string search)
        {
            bool found = false;
            
            foreach (Film i in listFilms)
            {
                if (i.IdFilm.Equals(search))
                {
                    var table = new Table();

                    table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");
                    table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.ImdbPoints.ToString());
                    Console.WriteLine(table.ToString());
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Film was found!");
            }        }

        public void DeleteFilmByID(string search)
        {
            SearchFilmByID(search);
            var itemToRemove = listFilms.SingleOrDefault(r => r.IdFilm ==search);
            if (itemToRemove != null)
            {
                listFilms.Remove(itemToRemove);
                Console.WriteLine("Successfully Deleted"); 
            }
        }
        public void UpdateFilmByID(string search)
        {
             bool found = false;
            
            foreach (Film i in listFilms)
            {
                if (i.IdFilm.Equals(search))
                {
                    var table = new Table();

                    table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");
                    table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.ImdbPoints.ToString());
                    Console.WriteLine(table.ToString());
                    found = true;
                    //Input Name of film
                    Console.Write("Enter Name : ");
                    i.Name = Console.ReadLine();
                    //Input Kind
                    Console.Write("Enter Kind of Film: ");
                    i.Kind = Console.ReadLine();
                    //Input Dicertor
                    Console.Write("Enter Director of film: ");
                    i.Director = Console.ReadLine();
                    //Input Film classification
                    Console.Write("Enter Film Classification: ");
                    i.FilmClassification = Console.ReadLine();
                    //Input film adaptation
                    Console.Write("Enter Film Adaption: ");
                    i.FilmAdaptation = Console.ReadLine();
                    //Input Film duration
                    Console.Write("Enter Film Duration: ");
                    i.FilmDuration = DateTime.Parse(Console.ReadLine());
                    //Input Release date
                    Console.Write("Enter Film  Release Date: ");
                    i.ReleaseDate = DateTime.Parse(Console.ReadLine());
                    //Input Imdb points
                    Console.Write("Enter Imdb points: ");
                    i.ImdbPoints = double.Parse(Console.ReadLine());
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Film was found!");
            }
        }
        public void SoftFilmByID()
        {
            List<Film> sortedList = listFilms.OrderBy(o=>o.ReleaseDate).ToList();
            sortedList.Reverse();
            var table = new Table();

            table.SetHeaders("No", "ID Film", "Name", "Kind", "Director", "MPAA","Film Adaptation","Film Duration", "Release Date","Imdb");
            
            foreach (Film i in sortedList)
            {
                table.AddRow($"{i.Id}", i.IdFilm, i.Name, i.Kind, i.Director, i.FilmClassification,i.FilmAdaptation,i.FilmDuration.ToString("hh:mm:ss"),i.ReleaseDate.ToString("dd/MM/yyyy"),i.ImdbPoints.ToString());
            }
            Console.WriteLine(table.ToString());        
        }
    }
}