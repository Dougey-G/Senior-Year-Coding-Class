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
                    file2.Add(line);
                    //Console.WriteLine();
                }

                //if(int or string == random)
                //{
                Console.WriteLine("The numbers are in random order");
                //}

                //if(int or string == file2.Count + 1 )
                //{
                Console.WriteLine("The numbers are in ascending order");
                //}

                //if(int or string == file2.Count - 1 )
                //{
                Console.WriteLine("The numbers are in descending order");
                //}

                //if(int or string != int)
                //{
                Console.WriteLine("The input was invalid");
                //}
            }

            string path3 = AppDomain.CurrentDomain.BaseDirectory + "Prob03.in.txt";
            List<string> file3 = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file3.Add(line);
                    //Console.WriteLine();
                }

                // Could you please check this part?

                for (int i = 0; i < 26; i++)
                {
                    // int a = 0;
                    //Decoder("a" == 0);
                    //...
                    // int m = 13;
                    //Decoder("m" == 13);
                    //...
                    // int z = 26;
                    //Decoder("z" == 26);
                }

                // Could you also please check this part?

                //public static string IntToLetters(int value)
                //{
                //    string decoder = string.Empty;
                //    while (value >= 0)
                //    {
                //        decoder = (char)('a' + value % 26) + result;
                //        value-- == 26;
                //    }
                //    return result;
                //}
            }

            string path4 = AppDomain.CurrentDomain.BaseDirectory + "Prob03.in.txt";
            List<string> file4 = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file4.Add(line);
                    //Console.WriteLine();
                }

                // Could you also please check this part too?

                //factorials = n!;

                //for (int i = 0; i < factorials.Length; i++)
                //{
                // i <= n!
                // n! = n * n<=n
                // factorials = number chosen * number chosen <= number chosen
                //}

                // You can ignore examples, just a helpful tip for me
                //Examples
                //1! = 1*1 = 1
                //...
                //4! = 4*3*2*1 = 24
                //...
                //25! = 25*24*23*22*21*20*19*18*17*16*15*14*13*12*11*10*9*8*7*6*5*4*3*2*1 = 1.5511e + 25
                //...
                //50! = 50*49*48*47*46*45*44*43*42*41*40*39*38*37*36*35*34*33*32*31*30*29*28*27*26*25*24*23*22*21*20*19*18*17*16*15*14*13*12*11*10*9*8*7*6*5*4*3*2*1 = 3.0414e + 64
            }
        }
    }
}