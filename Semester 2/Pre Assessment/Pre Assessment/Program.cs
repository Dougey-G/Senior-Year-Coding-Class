using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string result; 
            do
            {
                Console.WriteLine("Please enter the number you would like to perform");
                Console.WriteLine("1. Print Hello World");
                Console.WriteLine("2. Add two integers together");
                Console.WriteLine("3. Calulcate the area of a circle given just the radius");
                Console.WriteLine("4. Calculate the area of a triangle given the length of all three sides");
                Console.WriteLine("5. Given an integer n, draw a square using the ASCII character 'X' that has the width of n");
                Console.WriteLine("6. Given an integer n, draw a hollow square using the ASCII character 'X' that has a width of n");
                Console.WriteLine("7. Given two integer variables, swap their values");
                Console.WriteLine("8. Reverse a string using a for loop");
                Console.WriteLine("9. End the program");
                result = Console.ReadLine();



                if (result == "1")
                {
                    Console.WriteLine("Hello World");
                    Console.WriteLine();
                }

                if (result == "2")
                {
                    Console.WriteLine("Write the first number");
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the second number");
                    int input2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(input + input2);
                    Console.WriteLine();
                }

                if (result == "3")
                {
                    Console.WriteLine("What is the radius?");
                    int r = int.Parse(Console.ReadLine()); 
                    Console.WriteLine(Math.PI * r * r);
                    Console.WriteLine();
                }

                if (result == "4")
                {
                    Console.WriteLine("What's the first side of the triangle?");
                    float side = int.Parse(Console.ReadLine());
                    Console.WriteLine("What's the second side?");
                    float side2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("What's the third side?");
                    float side3 = int.Parse(Console.ReadLine());
                    float a = ((side + side2 + side3) / 2);
                    double total = (a - side) * (a - side2) * (a - side3);
                    Console.WriteLine(Math.Sqrt(total));

                }

                if (result == "5")
                {
                    Console.WriteLine("What's the area length? (i.e. 2 for 2 x 2)");
                    int length = int.Parse(Console.ReadLine());
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine();
                }

                if (result == "6")
                {
                    Console.WriteLine("What's the area length? (i.e. 2 for 2 x 2)");
                    int length = int.Parse(Console.ReadLine());
                    for (int x = 1; x <= length; x++)
                    {
                        for (int y = 1; y <= length; y++)
                        {
                            if (x == 1 || x == length || y == 1 || y == length)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                if (result == "7")
                {
                    Console.WriteLine("What's the first interger");
                    int integer1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("What's the second interger");
                    int integer2 = int.Parse(Console.ReadLine());
                    int temp = 0;
                    temp = integer1;
                    integer1 = integer2;
                    integer2 = temp;

                    Console.WriteLine("First flipped interger is: " + integer1);
                    Console.WriteLine("Second flipped interger is: " + integer2);
                    Console.WriteLine();
                }

                if (result == "8")
                {
                    Console.WriteLine("What is the string you want to reverse?");
                    string original = Console.ReadLine();
                    int p = original.Length;
                    Console.Write("Reversed string is: ");
                    for (int i = 1; i < original.Length + 1; i++)
                    {
                        Console.Write(original[p - i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }

            } while (result != "9");
        }
    }
}
