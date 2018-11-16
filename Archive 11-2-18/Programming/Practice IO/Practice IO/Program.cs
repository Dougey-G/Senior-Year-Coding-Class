using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
            string path = @"C:\Users\171282\Documents\Senior-Year-Coding-Class\Archive 11-2-18\Mario.txt";
            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }
            Console.WriteLine("1. Create File");
            Console.WriteLine("2. Delete File");
            Console.WriteLine("3. Load File");
            // Look at 2 links

            if (result == "1")
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("(insert character attributes");
            }

            if (result == "2")
            {
                
            }

            if (result == "3")
            {
                StreamReader sr = new StreamReader(path);
            }
        }
    }
}
