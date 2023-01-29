
using Seminar_8;
/*Задача 54: Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива. */
Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу,\n" +
    "которая упорядочит по убыванию элементы каждой строки двумерного массива");
int[,] matrix54 = Matrix.GetMatirxInts();
Matrix.FillMatrixRandomInts(matrix54);
Matrix.GetSortedRow(matrix54);
Matrix.Print(matrix54);
Console.WriteLine();

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
 которая будет находить строку с наименьшей суммой элементов. */
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,\n" +
    " которая будет находить строку с наименьшей суммой элементов.");
int[,] matrix56 = Matrix.GetMatirxInts();
Matrix.FillMatrixRandomInts(matrix56);
Matrix.Print(matrix56);
Matrix.GetRowMinValue(matrix56);
Console.WriteLine();

/*Задача 58: Задайте две матрицы. Напишите программу,
 *которая будет находить произведение двух матриц. */
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу,\n" +
    " которая будет находить произведение двух матриц.");
Console.WriteLine("Получение первой матрицы");
int[,] matrixA = Matrix.GetMatirxInts();
Matrix.FillMatrixRandomInts(matrixA);
Console.WriteLine("Получение второй матрицы");
int[,] matrixB = Matrix.GetMatirxInts();
Matrix.FillMatrixRandomInts(matrixB);
Console.WriteLine("Произведение");
int[,] array = Matrix.GetMultiplication(matrixA, matrixB);
Matrix.Print(array);
Console.WriteLine();

/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 *Напишите программу, которая будет построчно выводить массив,
 *добавляя индексы каждого элемента.*/
Console.WriteLine("Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.\n" +
    "Напишите программу, которая будет построчно выводить массив,\n" +
    "добавляя индексы каждого элемента.");
int[,,] array3D = Matrix3D.GetMatirx3DInts();
Matrix3D.FillMatrixRandomInts(array3D);
Matrix3D.GetValueOfIndex(array3D);
Console.WriteLine();

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
int[,] arraySpiral = Matrix.Spiral(4);
Matrix.Print(arraySpiral);
