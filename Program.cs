using System;
using ManageMovie.Classes;

namespace ManageMovie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }
        private static void MainMenu()
        {
            int choice=0;
            while (choice!=3)
            {
                Console.WriteLine("---------- NguyenFlix ----------");
                Console.WriteLine("|1: Film                       |");
                Console.WriteLine("|2: Tv series                  |");
                Console.WriteLine("|3: Exit                       |");
                Console.WriteLine("--------------------------------");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MenuFilm();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                }
            }
        }
        private static void MenuFilm()
        {
            
            Film film = new Film();
            string search;
            film.FilmAdd();
            while (true)
            {
                Console.WriteLine("---------- NguyenFlix ---------");
                Console.WriteLine("1: Add New Film ");
                Console.WriteLine("2: View List Film  ");
                Console.WriteLine("3: Update information of Firm");
                Console.WriteLine("4: Soft Film ");
                Console.WriteLine("5: Search Film ");
                Console.WriteLine("6: Delete Film ");
                Console.WriteLine("7: Back to Main Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        film.AddFilm();
                        break;
                    case 2:
                        film.ViewListFilms();
                        break;
                    case 3:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        film.UpdateFilmById(search);
                        break;
                    case 4:
                        film.SortFilmByYear();
                        break;
                    case 5:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        film.SearchFilmById(search);
                        break;
                    case 6:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        film.DeleteFilmById(search);
                        break;
                    case 7:
                        MainMenu();
                        break;
                }
            }
            
        }
        
    }
    /*        private static void MenuTvSeries()
        {
            TvSeries tvSeries = new TvSeries();
            Season season = new Season();
            tvSeries.AddTvSerie();
            string search;
            while (true)
            {
                Console.WriteLine("---------- NguyenFlix ---------");
                Console.WriteLine("1: Add New Tv Series ");
                Console.WriteLine("2: View List Series  ");
                Console.WriteLine("3: Update information of Series");
                Console.WriteLine("4: Soft Tv series ");
                Console.WriteLine("5: Search Tv series ");
                Console.WriteLine("6: Delete Tv series ");
                Console.WriteLine("7: Back to Main Menu");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        tvSeries.AddTvSeries();
                        break;
                    case 2:
                        tvSeries.ViewListTvSeries();
                        break;
                    case 3:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        break;
                    case 7:
                        MainMenu();
                        break;
                }
            }
        }*/
}