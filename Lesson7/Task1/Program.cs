﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// * Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9 */


// Console.WriteLine("Create 2d array: enter m(rows) and n(colums)");
// double[,] arrayCreate = CreatedDoubleRandom2dArray( 5, 5);
// PrintArray(arrayCreate);

// double[,] CreatedDoubleRandom2dArray(uint m, uint n)
// {
//     Random rnd = new Random();
//     double[,] array = new double[m, n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Math.Round(rnd.NextDouble() * rnd.Next(-10,11), 1);
//         }
//     }
//     return array;
// }

// void PrintArray(double [,] array)
//     {
//         for (var i = 0; i < array.GetLength(0); i++)
//         {
//             for (var j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}    ");
//             }
//             Console.WriteLine();
//         }
//     }