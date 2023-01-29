using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_8
{
    internal class Matrix
    {
        public static int[,] GetMatirxInts()
        {
            int row = Value.getInt("Введите количество строк массива:");
            if (row <= 0)
            {
                Console.WriteLine("Количество строк не может быть меньше или равно нулю");
                row = Value.getInt("Введите количество строк массива:");
            }
            int columns = Value.getInt("Введите количество столбцов массива:");
            if (columns <= 0)
            {
                Console.WriteLine("Количество столбцов не может быть меньше или равно нулю");
                columns = Value.getInt("Введите количество столбцов массива");
            }
            return new int[row, columns];
        }

        public static int[,] FillMatrixRandomInts(int[,] matrixInts)
        {
            int min = Value.getInt("Введите минимальное значение массива");
            int max = Value.getInt("Введите максимальное значение массива");
            Random random = new Random();
            for (int i = 0; i < matrixInts.GetLength(0); i++)
            {
                for (int j = 0; j < matrixInts.GetLength(1); j++)
                {
                    matrixInts[i, j] = random.Next(min, max);
                }
            }
            return matrixInts;
        }

        public static void Print<T>(T[,] matrix)
        {
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]:D2} ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] GetSortedRow(int[,] matrixInts)
        {
            int[] temp = new int[matrixInts.GetLength(1)];
            for (int i = 0; i < matrixInts.GetLength(0); i++)
            {
                for (int j = 0; j < matrixInts.GetLength(1); j++)
                {
                    temp[j] = matrixInts[i, j];
                }
                Array.Sort(temp);
                Array.Reverse(temp);
                for (int j = 0; j < matrixInts.GetLength(1); j++)
                {
                    matrixInts[i, j] = temp[j];
                }
            }
            return matrixInts;
        }
        public static void GetRowMinValue(int[,] matrixInts)
        {
            int min = Int32.MaxValue;
            int row = 0;
            for (int i = 0; i < matrixInts.GetLength(0); i++)
            {
                int sumi = 0;
                for (int j = 0; j < matrixInts.GetLength(1); j++)
                {
                    sumi += matrixInts[i, j];
                }
                if (min > sumi)
                {
                    min = sumi;
                    row = i + 1;
                }
            }
            Console.WriteLine($"Строка с наименьшей суммой - {row}.");
        }

        public static int[,] GetMultiplication(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                    for (int k = 0; k < matrixB.GetLength(0); k++)
                    {
                        matrix[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matrix;
        }

        public static int[,] Spiral(int lehgthMatrix)
        {
            int[,] matrix = new int[lehgthMatrix, lehgthMatrix];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = matrix.GetLength(1);
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = matrix.GetLength(1) * (dirChanges % 2) + matrix.GetLength(0) *
                        ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dy;
                row += dx;
            }
            return matrix;
        }
    }
}
