﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */


// int[,] genArray = GeneratedRandom2dArray();
// Print2dGenArray(genArray);
// Console.WriteLine();
// int[,] arrayOrder = CopyredArray(genArray);
// BubbleSort(arrayOrder);
// Print2dGenArray(arrayOrder);

// //коппирование массива
// int[,] CopyredArray(int[,] array)
// {
//     int[,] arr = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arr[i, j] = array[i, j];
//         }
//     }
//     return arr;
// }
// //сортировка "пузырёк" (не смог родить метод переноса значений из старого массива в новый с одновременной сортировкой)
// void BubbleSort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int buffer = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = buffer;
//                 }
//             }
//         }
//     }
// }

// int[,] GeneratedRandom2dArray()
// {
//     Random rnd = new Random();
//     int rows = rnd.Next(2, 7);
//     int columns = rnd.Next(2, 7);
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(-10, 11);
//         }
//     }
//     return array;
// }
// // Печать массива
// void Print2dGenArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"[{array[i, j]}]" + "\t");
//         }
//         Console.WriteLine();
//     }
// }
