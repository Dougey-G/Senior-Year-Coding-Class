using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //string result = Console.ReadLine();

            // Console.WriteLine("Which Store just survived Bankruptcy, within the last month?");
            // string[] stores = { "Sears" , "Toys R Us", "Radio Shack"};

            //var query = stores.Select((stores, index) => new {index, str = stores.Substring(0, index) });

            // if (result == "Sears")
            // {
            // Console.WriteLine("You are right!");
            // }

            // if (result == "toys r us")
            // {
            // Console.WriteLine("Sorry, try again");
            // }

            // if (result == "radio shack")
            // {
            // Console.WriteLine("Sorry, try again");
            // }

            string[] systems = { " Nintendo Switch", "Wii U", "Wii", "GameCube", "Nintendo 64", "Super NES"};

            var query = systems.Select((system, index) => new { index, str = fruit.Substring(0, index) });

            foreach (var obj in query)
        }
    }
}
