using System;
using ManageMovie.Classes;

namespace ManageMovie
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MenuFilm();
        }

        private static void MenuFilm()
        {
            int choice=0;
            Film film = new Film();
            string search;
            film.FilmAdd();
            while (choice!=7)
            {
                Console.WriteLine("---------- NguyenFlix ---------");
                Console.WriteLine("1: Add New Film ");
                Console.WriteLine("2: View List Film  ");
                Console.WriteLine("3: Update information of Firm");
                Console.WriteLine("4: Soft Film ");
                Console.WriteLine("5: Search Film ");
                Console.WriteLine("6: Delete Film ");
                Console.WriteLine("7: Back to Main Menu");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        film.AddFilm();
                        break;
                    case 2:
                        film.ViewListFilm();
                        break;
                    case 3:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        film.UpdateFilmByID(search);
                        break;
                    case 4:
                        film.SoftFilmByID();
                        break;
                    case 5:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        film.SearchFilmByID(search);
                        break;
                    case 6:
                        Console.Write("Input Id film to search: ");
                        search = Console.ReadLine();
                        film.DeleteFilmByID(search);
                        break;
                   case 7:
                       Console.WriteLine("-------------------------------");
                        Console.WriteLine("Goodbye.");
                        break;
                }
            }
            
        }
        
    }
}