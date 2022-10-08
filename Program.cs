using System;

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
            Console.WriteLine("---------- NguyenFlix ---------");
            Console.WriteLine("1: Add New Film or Tv series");
            Console.WriteLine("2: View List Film or List tv series ");
            Console.WriteLine("3: Add new season,new episodes for tv series");
            Console.WriteLine("4: Update information of Firm");
            Console.WriteLine("5: Soft Film ,Tv series");
            Console.WriteLine("5: Search Film or Tv Series");
            Console.WriteLine("6: Exit");
        }
    }
}