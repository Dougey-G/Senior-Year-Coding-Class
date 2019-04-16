using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code_Quest_2018
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

                int PASS_or_FAIL(int num)
                {
                    int grade = 0;
                    if (grade < 70)
                    {
                        Console.WriteLine("FAIL");
                    }
                    else
                    {
                        Console.WriteLine("PASS");
                    }
                    return grade;
                }
            }

            //string path2 = AppDomain.CurrentDomain.BaseDirectory + "Prob02.in.txt";
            //List<string> file2 = new List<string>();
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    string line2;
            //    while ((line2 = sr.ReadLine()) != null)
            //    {
            //        file2.Add(line2);
            //        //Console.WriteLine();
            //    }

            //}

            string path3 = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in.txt";
            List<string> file3 = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line3;
                while ((line3 = sr.ReadLine()) != null)
                {
                    file.Add(line3);
                    //Console.WriteLine();
                }
                if (line3 == "1th")
                {
                    line3.Replace("1th", "1st");
                }

                if (line3 == "2th")
                {
                    line3.Replace("2th", "2nd");
                }

                if (line3 == "3th")
                {
                    line3.Replace("3th", "3rd");
                }
                //...Need to continue
            }

            string path4 = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in.txt";
            List<string> file4 = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {

            }
        }
    }
}
