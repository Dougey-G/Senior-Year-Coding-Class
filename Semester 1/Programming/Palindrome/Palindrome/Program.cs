using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            Console.WriteLine("type word/phrase");
            s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");
            s = s.Replace("!", "");
            s = s.Replace(".", "");
            s = s.Replace("?", "");
            s = s.Replace("@", "");
            s = s.Replace("&", "");
            s = s.Replace(",", "");
            s = s.Replace(";", "");
            s = s.Replace(":", "");


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    Console.WriteLine("Not a Palindrome");
                    break;
                }
            
                else if (s[i] == s[s.Length - i - 1]&& i>= s.Length/2)
                {
                    Console.WriteLine("Palindrome");
                    break;
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

