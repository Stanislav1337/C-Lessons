﻿// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*\

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да*/

int number = ChoiceMethodEnter();
int[] arrayReversNum = GetArrayFromNumber(number);
int result = ComparisonArrays(arrayReversNum);

if (result == 1)
{
    Console.WriteLine($"Number {number} это палидромм");
}
else
{
    Console.WriteLine($"Number {number} это не палиндромм");
}

int InputIntNumberTryParse()
{
    Console.WriteLine("Enter number, please.");
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);

    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return -1;
    }
    else
    {
        Console.WriteLine($"{num} -- it's number user entered.");
        return num;
    }
}

int RandomIntNumber()
{
    Random random = new Random();
    int number = random.Next(10, 100000);
    Console.WriteLine($"{number} -- it's number from Random [10 - 99999]");
    return number;
}

int ChoiceMethodEnter()
{
    Console.WriteLine("Please, choosed method input number:");
    Console.WriteLine("1) Random number [10 - 99999]");
    Console.WriteLine("2) Usering enter");
    Console.WriteLine("Enter [1] or [2]");
    bool isParsed = int.TryParse(Console.ReadLine(), out int numChoice);
    if (!isParsed)
    {
        Console.WriteLine("Sorry, but You entered bullshit. Please, number enter.");
        return -1;
    }
    else
    {
        int num;
        if (numChoice == 1)
        {
            num = RandomIntNumber();
        }
        else
        {
            num = InputIntNumberTryParse();
        }
        return num;
    }
}



int ComparisonArrays (int[] arr)
{
    int index = arr.Length;
    int result = 0;
    int i = 0;
    while (i < index / 2)
    {
        if (arr[i] != arr[(index-i-1)])
        {
            result = 0;
            
        }
        else
        {
            result = 1;
        }
        i++;
    }
    return result;
}

int[] GetArrayFromNumber(int enteredNumber)
{
    int count = 1;
    int numberDivided = enteredNumber;
    while (numberDivided > 10)
    {
        numberDivided = numberDivided / 10;
        count++;
    }

    numberDivided = enteredNumber;
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = numberDivided % 10;
        numberDivided = numberDivided / 10;
    }
    return arr;
}