using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(5);
            //DrawBoard(Board);
        }

        static void Print(int i)
        {
            Console.WriteLine("Integer " + i);
        }

        static void Print(int[] array)
        {
            char[,] Board = new char[0, 4];
            DrawBoard(Board);

        }

        static void Print(int[,] array)
        {
            char[,] Board = new char[4, 4];
        }

        static void Print(int[][] array)
        {
            Console.ReadLine();
        }
        // Console.ReadLine();

        static void DrawBoard(char[,] board)
        {
            for (int j = 0; j < board.GetLength(0); j++)
            {
                for (int i = 0; i < board.GetLength(1); i++)
                {
                    Console.Write("| " + board[j, i] + " ");
                }
                Console.WriteLine("|");
            }
        }

        static void Print ()
        {
            double e = double.Parse(Console.ReadLine());

            double f = Math.PI;

            string printVal = f.ToString("0.##");
        }

       
    }
}