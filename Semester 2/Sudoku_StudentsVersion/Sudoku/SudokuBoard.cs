﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    public class SudokuBoard
    {
        /// <summary>
        /// Most recent row and most recent column, used for coloring the board
        /// </summary>
        int mrr = -1, mrc = -1;
        int[,] userChangedColors = new int[9, 9];

        /// <summary>
        /// The data structure used to hold board data.
        /// </summary>
        public int[,] Board { get; set; } = new int[9, 9];

        /// <summary>
        /// Defualt constructor for a sudokuboard. Randomly generates solvable boards.
        /// </summary>
        public SudokuBoard()
        {
            Board = new int[9, 9] {
                {0,0,0,2,6,0,7,0,1 },
                {6,8,0,0,7,0,0,9,0 },
                {1,9,0,0,0,4,5,0,0 },
                {8,2,0,1,0,0,0,4,0 },
                {0,0,4,6,0,2,9,0,0 },
                {0,5,0,0,0,3,0,2,8 },
                {0,0,9,3,0,0,0,7,4 },
                {0,4,0,0,5,0,0,3,6 },
                {7,0,3,0,1,8,0,0,0 }};
        }

        /// <summary>
        /// Overloaded constructor for a sudokuboard that reads in a file and generates
        /// the board based on that files information
        /// 
        /// There is a file in AppDomain.CurrentDomain.BaseDirectory called HardPuzzles.txt
        /// Each line has 81 characters, either a number or a '.' 
        /// '.' means that the cell should be empty (AKA 0) on the sudokuboard
        /// Use this data to parse a line into the board variable.
        /// </summary>
        /// <param name="fileName">Name of the file you want to load</param>
        public SudokuBoard(string fileName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "HardPuzzles.txt";
            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }
            Random rand = new Random();
            string puzzles = file[rand.Next(1, file.Count)];
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Board[i, j] = int.Parse(puzzles[count].ToString());
                    count = count + 1;
                }
                //Console.WriteLine("numbers" + count + "are already used");
            }
        }

        public SudokuBoard(SudokuBoard curboard)
        {
            Array.Copy(curboard.Board, this.Board, this.Board.Length);
        }

        /// <summary>
        /// Checks the entire board to see if it is valid or not.
        /// First, if ANY element in the board is empty (0) then the board is invalid.
        /// Next, check all rows to make sure every row contains explicitly 1-9, no duplicates.
        /// Next, check all columns to make sure every column contains explicity 1-9, no duplicates.
        /// Next, check all squares to make sure every square contains explicity 1-9, no duplicates.
        /// 
        /// If you are going to return false, because you found an error I recommend printing out the board, as well as
        /// the row/column of the error. Makes it easier to debug.
        /// </summary>
        /// <returns>
        /// True: The board is valid, and solved
        /// False: Something is wrong with the board, whether it has empty elements or is organized incorrectly
        /// </returns>
        public bool VerifyBoard()
        {
            //Checks all Rows in the board, makes sure they contain ONLY 1-9.
            for (int i = 0; i < 9; i++)
            {
                List<int> numbers = new List<int>();

                for (int j = 0; j < 9; j++)
                {
                    numbers.Add(Board[i, j]);
                }
                numbers = numbers.OrderBy(t => t).ToList();

                for (int x = 0; x < 9; x++)
                {
                    if (numbers[x] != x + 1)
                    {
                        return false;
                    }
                }
            }

            //Checks all Columns in the board, makes sure they contain ONLY 1-9.
            for (int j = 0; j < 9; j++)
            {
                List<int> numbers = new List<int>();

                for (int i = 0; i < 9; i++)
                {
                    numbers.Add(Board[i, j]);
                }
                numbers = numbers.OrderBy(t => t).ToList();

                for (int x = 0; x < 9; x++)
                {
                    if (numbers[j] != j + 1)
                    {
                        return false;
                    }
                }
            }

            //Checks all Boxes in the board, makes sure they contain ONLY 1-9.
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    List<int> numbers = new List<int>();

                    for (int UpperRowBox = i - i % 3; UpperRowBox < i - i % 3 + 3; UpperRowBox++)
                    {
                        for (int LeftColBox = j - j % 3; LeftColBox < j - j % 3 + 3; LeftColBox++)
                        {
                            numbers.Add(Board[UpperRowBox, LeftColBox]);
                        }
                    }
                    numbers = numbers.OrderBy(t => t).ToList();

                    for (int x = 0; x < 9; x++)
                    {
                        if (numbers[x] != x + 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Your code must look at all the Sudoku board cells in the specified column to find what digits are already used; none of those digits can be used in the blank cell. 
        /// Similarly, the code must look at all the cells in the specified row and reject any digits found. 
        /// And finally, your code must look at all 9 cells in the 3x3 box and reject any digits found.
        /// 
        /// Looking through the 3x3 box is easy once you know where the upper-left corner of the box is, so here is some help.The upper-left corner of the box is at:
        /// int upperRowBox = row - row % 3;
        /// int leftColBox = col - col % 3;
        /// 
        /// Your code must create and return a new list of ints, containing digits that are not used in the cell’s row, column, or box. 
        /// The list might have zero entries, or nine entries, or anything in between.
        /// 
        /// This method will get executed hundreds or even millions (yes, millions) of times depending on how hard or easy the Sudoku puzzle is. 
        /// If you make a coding mistake in this method, it will be incredibly hard to find (Which of those millions went wrong?).
        /// Therefore you have been provided unit tests that you can use to verify that your FindLegalDigits implementation is correct.
        /// </summary>
        /// <param name="row">Index of the row we want to get results for</param>
        /// <param name="col">Index of the column we want to get the results for</param>
        /// <returns>List of valid integers for the given row and column</returns>
        public List<int> FindLegalDigits(int row, int col)
        {
            //Create list of all possible digits (1-9)
            List<int> ValidValues = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Remove from the list all elements in the row

            for (int i = 0; i < 9; i++)
            {
                ValidValues.Remove(Board[row, i]);
            }

            //Remove from the list all elements in the column

            for (int i = 0; i < 9; i++)
            {
                ValidValues.Remove(Board[i, col]);
            }

            //Remove from the list all elements in the box

            List<int> numbers = new List<int>();

            int sx = row - row % 3;
            int sy = col - col % 3;

            for (int i = sx; i < sx + 3; i++)
            {
                for (int j = sy; j < sy + 3; j++)
                {
                    ValidValues.Remove(Board[i, j]);
                }
            }
            //return the list

            return ValidValues;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Prints out the sudoku board in an easily understandable way
        /// </summary>
        public void PrintBoard()
        {
            Console.WriteLine("Y  1  2  3   4  5  6   7  8  9");
            Console.WriteLine("X  ---------------------------");
            for (int row = 0; row < 9; row++)
            {
                if (row % 3 == 0 && row != 0)
                {
                    Console.WriteLine("  ---------+---------+---------");
                }
                Console.Write(row + 1 + "|");
                for (int col = 0; col < 9; col++)
                {
                    if (col % 3 == 0 && col != 0)
                    {
                        Console.Write("|");
                    }
                    if (mrr == row && mrc == col)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (userChangedColors[row, col] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(" " + Board[row, col] + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Applies a value to a board in the given row and column
        /// </summary>
        /// <param name="val">The value to apply (1-9)</param>
        /// <param name="row">The row (1-9)</param>
        /// <param name="col">The column (1-9)</param>
        /// <returns>If the place was successful or not</returns>
        public bool PlaceValue(int val, int row, int col)
        {
            //if any argument is outside of the range 0-8, return false
            if (val < 1 || val > 9 || row < 0 || row > 8 || col < 0 || col > 8)
                return false;

            mrr = row;
            mrc = col;

            userChangedColors[row, col] = 1;

            //Apply the value
            Board[row, col] = val;
            return true;
        }
    }
}