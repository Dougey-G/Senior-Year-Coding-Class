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
            using (StreamReader sr = new StreamReader(path2))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file2.Add(line);
                }
            }

            for (int i = 0; i < file2.Count; i++)
            {
                string[] Split = file2[i].Split(' ');
                List<int> ints = new List<int>();
                int left;
                int right;
                bool asc = true;
                bool desc = true;
                bool invalid = false;
                for (int j = 0; j < Split.Length - 1; j++)
                {
                    if (int.TryParse(Split[j], out left) == false)
                    {
                        invalid = true;
                        Console.WriteLine("The input was invalid");
                        break;
                    }

                    if (int.TryParse(Split[j + 1], out right) == false)
                    {
                        invalid = true;
                        Console.WriteLine("The input was invalid");
                        break;
                    }

                    if (left < right)
                    {
                        desc = false;
                    }

                    if (left > right)
                    {
                        asc = false;
                    }
                }

                if (invalid == false)
                {
                    if (desc == false && asc == false)
                    {
                        Console.WriteLine("It's in a random order");
                    }

                    else if (asc == false)
                    {
                        Console.WriteLine("It's descending");
                    }

                    else if (desc == false)
                    {
                        Console.WriteLine("It's ascending");
                    }
                }
            }
            Console.ReadLine();

            string path4 = AppDomain.CurrentDomain.BaseDirectory + "Prob04.in.txt";
            List<string> file4 = new List<string>();
            using (StreamReader sr = new StreamReader(path4))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file4.Add(line);
                }

                for (int i = 0; i < file4.Count; i++)
                {
                    int numberInt = int.Parse(file4[i]);
                    int result = numberInt;

                    for (int j = 1; j < numberInt; j++)
                    {
                        result = result * j;
                    }

                    file4[i] = result.ToString();
                }

                foreach (string s in file4)
                {
                    Console.WriteLine(s);
                }
                Console.ReadLine();
            }
        }
    }
}