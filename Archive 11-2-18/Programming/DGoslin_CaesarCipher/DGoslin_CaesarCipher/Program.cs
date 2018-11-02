using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGoslin_CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******************************************");
            Console.WriteLine("1. Encrypt");
            Console.WriteLine("2. Decrypt");
            Console.WriteLine("3. Brute Force");
            Console.WriteLine("*******************************************");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Encrypt();
            }

            if (result == "2")
            {
                Decrypt();
            }

            if (result == "3")
            {
                BruteForce();
            }
        }

        static void Encrypt()
        {
            Console.Write("Enter a string to encyrpt: ");
            string alpha = Console.ReadLine();
            Console.Write("Enter a shift value: ");
            int shift2 = int.Parse(Console.ReadLine());
            Console.Write("Your encrytped word is: ");

            for (int i = 0; i < alpha.Length; i++)
            {
                char h = alpha[i];
                char shifted2 = (char)(h + shift2);
                if (shifted2 > 122)
                {
                    shifted2 = (char)((int)shifted2 - 26);
                }
                Console.Write(shifted2);
            }
            Console.ReadLine();
        }

        static void Decrypt()
        {
            Console.Write("Enter a string to decyrpt: ");
            string alpha2 = Console.ReadLine();
            Console.Write("Enter the original shift value: ");
            int shift3 = int.Parse(Console.ReadLine());
            Console.Write("Your decrytped word is: ");


            for (int i = 0; i < alpha2.Length; i++)
            {
                char j = alpha2[i];
                char shifted3 = (char)(j - shift3);
                if (shifted3 < 97)
                {
                    shifted3 = (char)((int)shifted3 + 26);
                }
                Console.Write(shifted3);
            }
            Console.ReadLine();
        }

        static void BruteForce()
        {
            Console.Write("Enter a string to decyrpt by brute force: ");
            string alpha2 = Console.ReadLine();
            Console.WriteLine("Here are all of the possibilies");

            for (int k = 0; k < 26; k++)
            {
                for (int i = 0; i < alpha2.Length; i++)
                {
                    char j = alpha2[i];
                    char shifted3 = (char)(j - k);
                    if (shifted3 < 97)
                    {
                        shifted3 = (char)((int)shifted3 + 26);
                    }
                    Console.Write(shifted3);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
