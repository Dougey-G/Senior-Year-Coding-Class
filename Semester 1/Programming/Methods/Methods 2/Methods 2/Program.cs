using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Program
    {
        static int input = 0;
        static void Main(string[] args)
        {
            // Print3x3Square();
            // Console.WriteLine();
            // Print3x6Square();
            // Console.WriteLine();
            // Print6x3Rectangle();
            PrintRectangleBySize(3, 5);
            
            do
            {
                input = DisplayMenuToUserAndGetInput();
            } while (input != -1);

            //Console.ReadLine();
        }
        static int DisplayMenuToUserAndGetInput()
        {
            Console.WriteLine("Enter x value");
            int inputx = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y value");

            int inputy = int.Parse(Console.ReadLine());
            if (inputx == 0 || inputy == 0)
            {
                input = -1;
            }
            PrintRectangleBySize(inputx, inputy);
            return input;
        }
        //static void Print3x3Square()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write("X");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //static void Print3x6Square()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write("X");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //static void Print6x3Rectangle()
        //{
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write("X");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        static void PrintRectangleBySize(int size, int sizeR)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < sizeR; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}
