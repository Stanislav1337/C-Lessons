// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*\

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да

Console.WriteLine("Введите целое число");
bool isInt = int.TryParse(Console.ReadLine(), out int num);
if (!(isInt)) {
    Console.WriteLine("Вы ввели неподходящее число");
} else {
    if (IsPallindrom(num)){
        Console.WriteLine($"Число {num} является палиндромом");
    } else {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

double[] InputCoord() {
    double[] coordinates = new double[3];
    Console.WriteLine("Введите координату точки X");
    bool isNumX = double.TryParse(Console.ReadLine(), out double x);
    if (isNumX) {
        coordinates[0] = x;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return InputCoord();
    }
    
    Console.WriteLine("Введите координату точки Y");
    bool isNumY = double.TryParse(Console.ReadLine(), out double y);
    if (isNumY) {
        coordinates[1] = y;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return InputCoord();
    }

    Console.WriteLine("Введите координату точки Y");
    bool isNumZ = double.TryParse(Console.ReadLine(), out double z);
    if (isNumY) {
        coordinates[2] = z;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return InputCoord();
    }
    return coordinates;
}*/









/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*int num = InputInt();
int[] squaresTable = GetTableOfSqures(num);
PrintArray(squaresTable);

int[] GetTableOfSqures(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = (int)(Math.Pow(i+1, 3));
    }
return arr;
}

void PrintArray (int[] arr){
    for (int i = 0; i< arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}*/