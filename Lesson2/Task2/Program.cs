// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/



// Console.WriteLine("Введите число");

// int num = int.Parse(Console.ReadLine());


// int res = 0;

// if (num > 100) 
// {
//     res = (num /10)% 10; }
// else{
//      res = num % 10;
// }

// if (num < 100) 
// {
//     Console.WriteLine ("Третьей цифры нет"); }
// else{
//     Console.WriteLine(res);
// }


Console.WriteLine("Введите число.");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (isParsed == true)
{
    if (number >= 100 | number <= -100)
    {   
        int number3 = number;
        if (number3 < 0)
        {
            number3 = number3 * -1;
        }
        
        if (number3 > 999)
        {
            while (number3 > 999)
            {
                number3 = number3 / 10;
            }
            number3 = number3 % 10;
        }
        
        else
        {   
            number3 = number3 % 10;
        }
        
        Console.WriteLine($"{number3} -- 'это 3 число из этого' {number}");
    }
    else
    {
        Console.WriteLine($"Прости, но у тебя нет 3-его числа из этого {number}.");
    }
}
else
{
    Console.WriteLine("Прости но это нам не подходит. Пожалуйста введи число");
}


