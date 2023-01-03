/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

// Random rnd = new Random();


// int number = rnd.Next(1,10);
// Console.WriteLine($"Number generated: {number}");


// int[] resultArray = NumberBetweenNto1(number, number);
// PrintArray(resultArray);

// // метод для расчёта чисел от N до 1 с записью в одномерный массив
// int[] NumberBetweenNto1(int num, int count, int[] arr = null, int index = 0)
// {
//     if (arr is null)
//     {
//         arr = new int[num];
//     }

//     if (index < arr.Length)
//     {
//         arr[index] = count;
//         NumberBetweenNto1(num, count-1, arr, index + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
    
//         for (int j = 0; j < array.Length; j++)
//         {
//             Console.Write($"[{array[j]}]" + "\t");
//         }
//         Console.WriteLine();
    
// }