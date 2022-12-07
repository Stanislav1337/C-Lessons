// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// using System;
// Random rnd = new Random();

// bool isInt = int.TryParse(Console.ReadLine(), out int num);
// if (!isInt){
//     Console.WriteLine("Это что угодно, но только не целое число");
// } 
// else{
//     int userLength = num;


// int[] userArray = ArrayFilling(userLength);
// PrintArr(userArray);

// test(userArray, userLength);

// int[] ArrayFilling(int userLength){
//     int[] arr = new int[userLength];
//     for (int i = 0; i < arr.Length; i++){
//         arr[i] = rnd.Next(0,2);
//     }
//     return arr;
// }

// void PrintArr (int[] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// }

// void test (int[] userArray, int userLength){

//     if (userArray.Length == userLength){
//         Console.WriteLine("Тест совместимости длины пройден успешно");
//     } else {
//         Console.WriteLine("Тест совместимости длины провален");
//     }

//     for (int i = 0; i < userArray.Length; i++){
//         if (!(i == 0 || i == 1)){
//             Console.WriteLine("Тест совместимости данных провален");
//         }
//     } 
//     Console.WriteLine("Тест совместимости данных пройден успешно");
// }