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

            float total = 0;
            
            for (int i = 0; i < file.Count; i++)
            {
                if (file[i].Contains("QUARTER"))
                {
                    file[i] = file[i].Substring(8);
                    total += float.Parse(file[i]) * .25f;
                }

                if (file[i].Contains("DIME"))
                {
                    file[i] = file[i].Substring(5);
                    total += float.Parse(file[i]) * .1f;
                }

                if (file[i].Contains("NICKEL"))
                {
                    file[i] = file[i].Substring(7);
                    total += float.Parse(file[i]) * .05f;
                }

                if (file[i].Contains("HALFDOLLAR"))
                {
                    file[i] = file[i].Substring(11);
                    total += float.Parse(file[i]) * .5f;
                }

                if (file[i].Contains("PENNY"))
                {
                    file[i] = file[i].Substring(6);
                    total += float.Parse(file[i]) * .01f;
                }
            }
            Console.WriteLine("$" + total.ToString("#.00"));
            Console.ReadLine();

            string path2 = AppDomain.CurrentDomain.BaseDirectory + "Prob02.in.txt";
            List<string> file2 = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                    //Console.WriteLine();
                }

                //if()
                //{

                //}


            }
        }
    }
}