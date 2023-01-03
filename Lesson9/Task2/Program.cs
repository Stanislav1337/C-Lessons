/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

// Random rnd = new Random();


// // int number = rnd.Next(1,10);


// Console.WriteLine("Enter number M and N");
// int numberM = rnd.Next(1,10);
// int numberN = rnd.Next(1,10);
// Console.WriteLine($"Number M generated: {numberM}");
// Console.WriteLine($"Number N generated: {numberN}");


// if (numberM > numberN) // проверка на M < N 
// {
//     int n = numberN;
//     numberN = numberM;
//     numberM = n;
// }

// int sumNumForMtoN = SumNumberBetweenMtoN(numberM, numberN);
// Console.WriteLine($"Number M = {numberM}; Number N = {numberN};");
// Console.WriteLine($"Sum numbers between M to N = {sumNumForMtoN}");

// // метод подсчёта суммы между M и N (границы включены)
// int SumNumberBetweenMtoN(int numM, int numN)
// {
//     if (numM > numN) return 0;
//     else return numN + SumNumberBetweenMtoN(numM, numN - 1);
// }