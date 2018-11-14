using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\171282\Documents\Senior-Year-Coding-Class\Archive 11-2-18\Example.txt";

            //StreamWriter sw = new StreamWriter(path);
            //sw.WriteLine("Hello,");
            //sw.WriteLine("It's a me, Mario.");
            //sw.Dispose();

            //string path = @"C:\Users\171282\Documents\Senior-Year-Coding-Class\Archive 11-2-18\Example.txt";
            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.WriteLine("Welcome");
            //    sw.WriteLine("New Galaxy");
            //}

            //string path;
            //path = @"C:\Users\171282\Documents\Senior-Year-Coding-Class\Archive 11-2-18\Example.txt";
            //path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";

            string path = @"C:\Users\171282\Documents\Senior-Year-Coding-Class\Archive 11-2-18\Example.txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }

            string result = Console.ReadLine();

            if (result == "1")
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("Hello,");
                sw.WriteLine("It's a me, Mario.");
                sw.Dispose();
            }

            if (result == "2")
            {
                StreamReader sr = new StreamReader(path);
                //sr.ReadLine("Hello");
                //sr.
            }
        }
    }
}
