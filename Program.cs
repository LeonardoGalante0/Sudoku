using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        public bool controlloSudoku(int[,] sudoku, int[,] soluzione)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(sudoku[i, j] != soluzione[i, j])
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] sudoku = {
                    { 3, 2, 1, 7, 0, 4, 0, 0, 0 },
                    { 6, 4, 0, 0, 9, 0, 0, 0, 7 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 4, 5, 9, 0, 0 },
                    { 0, 0, 5, 1, 8, 7, 4, 0, 0 },
                    { 0, 0, 4, 9, 6, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 2, 0, 0, 0, 7, 0, 0, 1, 9 },
                    { 0, 0, 0, 6, 0, 9, 5, 8, 2 }
            };
            int[,] soluzione = {
                    { 3, 2, 1, 7, 5, 4, 6, 9, 8 },
                    { 6, 4, 8, 2, 9, 3, 1, 5, 7 },
                    { 5, 7, 9, 8, 1, 6, 2, 3, 4 },
                    { 7, 8, 2, 3, 4, 5, 9, 6, 1 },
                    { 9, 6, 5, 1, 8, 7, 4, 2, 3 },
                    { 1, 3, 4, 9, 6, 2, 8, 7, 5 },
                    { 8, 9, 3, 5, 2, 1, 7, 4, 6 },
                    { 2, 5, 6, 4, 7, 8, 3, 1, 9 },
                    { 4, 1, 7, 6, 3, 9, 5, 8, 2 }
            };
            StampaSudoku(sudoku);
            Console.ReadKey();
        }
        public static void StampaSudoku(int[,] sudoku)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(sudoku[i, j] + " ");
                }
            }
        }
    }
}
