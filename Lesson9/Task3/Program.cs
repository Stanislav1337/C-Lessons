/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

// Random rnd = new Random();


// // int number = rnd.Next(1,10);


// Console.WriteLine("Enter number M and N");
// int numberM = rnd.Next(0,4);
// int numberN = rnd.Next(0,4);
// Console.WriteLine($"Number M generated: {numberM}");
// Console.WriteLine($"Number N generated: {numberN}");




// int a = AkkermanFuncion(numberN, numberM);
// Console.WriteLine(a);



// int AkkermanFuncion(int numN, int numM)
// {
//     if (numN == 0) return numM + 1;
//     else
//     {
//         if ((numN != 0) && (numM == 0)) return AkkermanFuncion(numN - 1, 1);
//         else return AkkermanFuncion(numN - 1, AkkermanFuncion(numN, numM - 1));
//     }
// }