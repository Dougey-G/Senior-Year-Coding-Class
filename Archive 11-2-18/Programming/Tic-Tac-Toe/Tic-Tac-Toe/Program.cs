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
            char result;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = ' ';
                }
            }

            do
            {
                DrawBoard(Board);
                ProcessTurn(Board, 'x');
                result = VerifyBoard(Board);
                if (result == 'x' || result == 't')
                {
                    break;
                }
                DrawBoard(Board);
                ProcessTurn(Board, 'o');
                result = VerifyBoard(Board);
            } while (result == ' ');

            if (result == 'x')
            {
                Console.WriteLine("x player wins");
                Console.ReadLine();
            }

            if (result == 'o')
            {
                Console.WriteLine("o player wins");
                Console.ReadLine();
            }

            if (result == 't')
            {
                DrawBoard(Board);
                Console.WriteLine("it's a tie");
                Console.ReadLine();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <returns>x if x wins, o if  o wins, ' ' otherwise</returns>
        static char VerifyBoard(char[,] board)
        { 
            if (board[0,0] == 'x' && board[0,1] == 'x' && board[0,2] == 'x')
            {
                return 'x';
            }

            if (board[1, 0] == 'x' && board[1, 1] == 'x' && board[1, 2] == 'x')
            {
                return 'x';
            }

            if (board[2, 0] == 'x' && board[2, 1] == 'x' && board[2, 2] == 'x')
            {
                return 'x';
            }

            if (board[0, 0] == 'o' && board[0, 1] == 'o' && board[0, 2] == 'o')
            {
                return 'o';
            }

            if (board[1, 0] == 'o' && board[1, 1] == 'o' && board[1, 2] == 'o')
            {
                return 'o';
            }

            if (board[2, 0] == 'o' && board[2, 1] == 'o' && board[2, 2] == 'o')
            {
                return 'o';
            }

            if (board[0, 0] == 'x' && board[1, 1] == 'x' && board[2, 2] == 'x')
            {
                return 'x';
            }

            if (board[0, 2] == 'x' && board[1, 1] == 'x' && board[2, 0] == 'x')
            {
                return 'x';
            }

            if(board[0, 0] == 'o' && board[1, 1] == 'o' && board[2, 2] == 'o')
            {
                return 'o';
            }

            if (board[0, 2] == 'o' && board[1, 1] == 'o' && board[2, 0] == 'o')
            {
                return 'o';
            }
            // if board no longer has any spaces, return t
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return ' ';
                    }
                }
            }

            return 't';
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="player"></param>
        static void ProcessTurn(char[,] board, char player)
        {
            Console.WriteLine(player + " it's your turn");
            Console.WriteLine("Please enter x coordinate");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter y coordinate");
            int y = int.Parse(Console.ReadLine());
            if (board[x, y] == ' ')
                board[x, y] = player;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
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