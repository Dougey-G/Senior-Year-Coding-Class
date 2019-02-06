using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code_Quest_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in.txt";
            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                    //Console.WriteLine();
                    
                }               
            }

            for (int i = 0; i < file.Count; i++)
            {
                Console.WriteLine(file[i]);
                // Console.Ignore (or RemoveAt) (file[3]);
                // Console.Ignore (or RemoveAt) (file[6]);
            }



            Console.ReadLine();

            //string result = Console.ReadLine();

            ////for (int i = 0; i < Quarter.Count; i++)
            //if (result == "1")
            //{
            //    Console.WriteLine(file[0]);
            // Console.WriteLine(file[0] * .25);
            //}

            ////for (int i = 0; i < Dime.Count; i++)
            //if (result == "2")
            //{
            //    Console.WriteLine(file[1]);
            //    Console.WriteLine(file[1] * .10);
            //}

            ////for (int i = 0; i < Nickel.Count; i++)
            //if (result == "3")
            //{
            //    Console.WriteLine(file[2]);
            //    Console.WriteLine(file[2] * .05);
            //}

            ////for (int i = 0; i < Dime.Count; i++)
            //if (result == "4")
            //{
            //    Console.WriteLine(file[4]);
            //    Console.WriteLine(file[4] *.10);
            //}

            ////for (int i = 0; i < HalfDollar.Count; i++)
            //if (result == "5")
            //{
            //    Console.WriteLine(file[5]);
            //    Console.WriteLine(file[5] *.50);
            //}

            ////for (int i = 0; i < Penny.Count; i++)
            //if (result == "6")
            //{
            //    Console.WriteLine(file[7]);
            //    Console.WriteLine(file[7] *.01);
            //}

            // Quarter, Dime, Nickel, HalfDollar, Penny
            // Quarter = .25
            // Dime = .1
            // Nickel = .05
            // HalfDollar = .5
            // Penny = .01
        }
    }
}
