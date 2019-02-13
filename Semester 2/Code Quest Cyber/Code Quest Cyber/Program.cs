using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Code_Quest_Cyber
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = AppDomain.CurrentDomain.BaseDirectory + "Prob01.in.txt";
            //List<string> file = new List<string>();
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        file.Add(line);
            //        //Console.WriteLine();
            //    }
            //}

            string path2 = AppDomain.CurrentDomain.BaseDirectory + "Prob02.in.txt";
            List<string> file2 = new List<string>();
            using (StreamReader sr = new StreamReader(path2))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file2.Add(line);
                    //Console.WriteLine();
                }
            }
            

            string Reverse(string text)
            {
                string reverse = String.Empty;
                for (int i = file2[0].Length; i > -1; i--)
                {
                    reverse += file2[i];
                }
                return reverse;
            }

            if (new string(file2[0].Reverse().ToArray()) == file2[0])
            {

                Console.WriteLine(file2[0]);
            }

            //Length ;
        }
    }
}
