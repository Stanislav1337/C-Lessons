/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */



// int[,] genArray = GeneratedRandom2dArray();
// Print2dGenArray(genArray);
// int result = MinRow (genArray);
// Console.WriteLine($"{result + 1} - ая строка содержит наименьшую сумму элементов");

// //Метод подсчёта суммы элементов строки двумерного массива с фиксированием результататов ввиде одномерного массива. 
// //Возвращает индекс одномерного массива.
// // Одномерный массив нигде не хранится.
// int MinRow (int [,] array)
// {
//     int[] arrstr = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++) sum = sum + array[i,j];
//         arrstr[i] = sum;
//     }
//     int res = 0;
//     int resIndex = 0;
//     for (int k = 1; k < arrstr.Length; k++)
//     {  
//         if(res > arrstr[k]) 
//         {
//             res = arrstr[k];
//             resIndex = k;
//         }
//     }
//     Console.WriteLine();
//     PrintArray(arrstr);
//         return resIndex;
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

// void PrintArray(int[] array)
// {
    
//         for (int j = 0; j < array.Length; j++)
//         {
//             Console.Write($"[{array[j]}]" + "\t");
//         }
//         Console.WriteLine();
    
// }