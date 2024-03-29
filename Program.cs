﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
         public static bool controlloSudoku(int[,] sudoku, int[,] soluzione)
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
                    { 3, 2, 1, 7, 5, 4, 0, 0, 0 },
                    { 6, 4, 8, 2, 9, 3, 1, 5, 7 },
                    { 5, 7, 9, 8, 1, 6, 2, 3, 4 },
                    { 7, 8, 2, 3, 4, 5, 9, 6, 1 },
                    { 9, 6, 5, 1, 8, 7, 4, 2, 3 },
                    { 1, 3, 4, 9, 6, 2, 8, 7, 5 },
                    { 8, 9, 3, 5, 2, 1, 7, 4, 6 },
                    { 2, 5, 6, 4, 7, 8, 3, 1, 9 },
                    { 4, 1, 7, 6, 3, 9, 5, 8, 2 }
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
            inserimento(sudoku);
            if(controlloSudoku(sudoku, soluzione))
            {
                Console.WriteLine("Sudoku Giusto.");
            } else
            {
                Console.WriteLine("Sudoku sbagliato.");
            }
            Console.ReadKey();
        }
        public static void StampaSudoku(int[,] sudoku)
        {
            Console.WriteLine("+-----+-----+-----+");

            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                    Console.Write("|{0}", sudoku[i - 1, j - 1]);

                Console.WriteLine("|");
                if (i % 3 == 0) Console.WriteLine("+-----+-----+-----+");
            }
        }

        public static void inserimento(int[,] sudoku)
        {
            while (true)
            {
                Console.WriteLine("In che riga vuoi inserire il numero? 0 PER USCIRE");
                int riga = Int32.Parse(Console.ReadLine());
                if (riga == 0) break;
                Console.WriteLine("In che colonna vuoi inserire il numero?");
                int colonna = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Che numero vuoi inserire?");
                int numero = Int32.Parse(Console.ReadLine());
                sudoku[(riga - 1), (colonna - 1)] = numero;
                StampaSudoku(sudoku);
            }
        }
    }
}
