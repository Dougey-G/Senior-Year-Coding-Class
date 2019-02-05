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
            }

            Console.ReadLine();
            //var lastItem = integerList.Last();

            // Quarter, Dime, Nickel, HalfDollar, Penny
            // Quarter = .25
            // Dime = .1
            // Nickel = .05
            // HalfDollar = .5
            // Penny = .01

            //for (int i = 0; i < Quarter.Count; i++)
            //{
            // Console.WriteLine(file[0]);
            //}

            //for (int i = 0; i < Dime.Count; i++)
            //{
            // Console.WriteLine(file[1]);
            //}

            //for (int i = 0; i < Nickel.Count; i++)
            //{
            // Console.WriteLine(file[2]);
            //}

            //for (int i = 0; i < Dime.Count; i++)
            //{
            // Console.WriteLine(file[3]);
            //}

            //for (int i = 0; i < HalfDollar.Count; i++)
            //{
            // Console.WriteLine(file[4]);
            //}

            //for (int i = 0; i < Penny.Count; i++)
            //{
            // Console.WriteLine(file[5]);
            //}
        }
    }
}
