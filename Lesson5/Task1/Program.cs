﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Array = GenerateArray(100, 1000, InputIntNumberTryParse());
// PrintArray(Array);
// int result = CounterEvenNumbers(Array);
// Console.WriteLine($"{result} it's amount even numbers in array (up).");



// int CounterEvenNumbers(int [] array)
// {
//     int count = 0;
//     int i = 0;
//     while (i < array.Length)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//         i++;
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         Console.Write($"[{array[i]}] ");
//     }
//     Console.WriteLine();
// }

// int[] GenerateArray(int min, int max, int length)
// {
//     Random random = new Random();
//     int[] array = new int[length];

//     for (var i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(min, max + 1);
//     }

//     return array;
// }

// int InputIntNumberTryParse()
// {
//     MSG();
//     Console.WriteLine("Enter number, please.");
//     bool isParsed = int.TryParse(Console.ReadLine(), out int num);

//     if (!isParsed)
//     {
//         Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
//         return -1;
//     }
//     else
//     {
//         Console.WriteLine($"{num} -- it's number user entered.");
//         return num;
//     }
// }

// void MSG ()
// {
//     Console.WriteLine("You must specify the number of array elements.");
// }