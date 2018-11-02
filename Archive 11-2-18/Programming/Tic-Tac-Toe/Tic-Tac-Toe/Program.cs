using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("X's go first, first to 3 in a row wins");
            //
            //Console.ReadLine();
            //bool sides;
            //int x = 0;
            char[,] Board = new char[3, 3];
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = ' ';
                }
            }
            DrawBoard(Board);
            ProcessTurn(Board, 'x');
            ProcessTurn(Board, 'o');
            ProcessTurn(Board, 'x');
            ProcessTurn(Board, 'o');
            ProcessTurn(Board, 'x');
            ProcessTurn(Board, 'o');
            ProcessTurn(Board, 'x');
            ProcessTurn(Board, 'o');
            ProcessTurn(Board, 'x');
            ProcessTurn(Board, 'o');
            ProcessTurn(Board, 'x');
            ProcessTurn(Board, 'o');
            Console.ReadLine();

            //{
            //    for (int i = 0; i < 1; i++)
            //    {
            //        for (int j = 0; j < 1; j++)
            //        {
            //            Console.Write("X");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.ReadLine();
            //}

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <returns>x if x wins, o if  o wins, ' ' otherwise</returns>
        static char VerifyBoard(char[,] board)
        { 
            if //(three are same)
            return ' ';
        }

        static void ProcessTurn(char[,] board, char player)
        {
            Console.WriteLine(player + " it's your turn");
            Console.WriteLine("Please enter x coordinate");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter y coordinate");
            int y = int.Parse(Console.ReadLine());
            if (board[x, y] == ' ')
                board[x, y] = player;
            DrawBoard(board);
        }

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
    }
}
