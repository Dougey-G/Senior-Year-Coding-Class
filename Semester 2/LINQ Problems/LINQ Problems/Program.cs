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

            // string[] stores = { "Sears" , "Toys R Us", "Radio Shack"};

            //var query = stores.Select((stores, index) => new {index, str = stores.Substring(0, index) });

           string[] systems = { "Nintendo Switch", "Nintendo Wii U", "Nintendo Wii", "Nintendo Game Cube", "Nintendo 64", "Super Nintendo ES", "Sony PS1", "Sony PS2", "SonyPSP", "Sony PS3", "Sony PSVita", "Sony PS4", "Microsoft Xbox", "Microsoft Xbox 360", "Microsoft Xbox One"};

            //var query = systems.Where(system => system.Substring(0, 8) == "Nintendo");
            var query = systems.Where(system => system.Contains("Nintendo"));

            foreach (string system in query)
            { 
                Console.WriteLine(system);
            Console.ReadLine();
            }
        }
    }
}
