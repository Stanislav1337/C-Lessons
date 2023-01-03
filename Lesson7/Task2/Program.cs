// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */



// int [,] generatedArray = GeneratedRandom2dArray();
// // Console.WriteLine("Enter row's and column's number for get number from array:");



// Print2dGenArray(generatedArray);

// string findResult = string.Empty;
// Random rnd = new Random();

// int column = rnd.Next(0,11); 
// int row = rnd.Next(0,11);
// Console.WriteLine($"corRow = {row}; corColum = {column}");
// bool result = FounderNumberInArray( column, row, generatedArray, out findResult);
// Console.WriteLine(findResult);

// //
// bool FounderNumberInArray(int coorRow, int coorColumn, int [,] array, out string findResult)
// {

//     if (coorRow < array.GetLength(0) && coorColumn < array.GetLength(1))
//     {
//         findResult = $"{array[coorRow,coorColumn]}";
//         return true;
//     }
//     else
//     {
//         findResult = "Sorry, not found";
//         return false;
//     }
// }

// // Генерация массива с случанйми строками/столбцами и значениями
// int[,] GeneratedRandom2dArray()
// {
//     Random rnd = new Random();
//     int rows = rnd.Next(3,7);
//     int columns = rnd.Next(3,7);
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(-20,21);
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
//            // Console.SetCursorPosition((0+6*j), 0);
//             Console.Write($"[{array[i, j]}]" + "\t");
//         }
//         Console.WriteLine();
//     }
// }