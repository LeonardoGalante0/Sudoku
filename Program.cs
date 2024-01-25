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
            StampaSudoku(sudoku);

            while (true)
            {
                Console.WriteLine("In che riga vuoi inserire il numero?");
                int riga = Int32.Parse(Console.ReadLine());
                Console.WriteLine("In che colonna vuoi inserire il numero?");
                int colonna = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Che numero vuoi inserire?");
                int numero = Int32.Parse(Console.ReadLine());

                sudoku[(riga-1), (colonna-1)] = numero;
                StampaSudoku(sudoku);
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
    }
}
