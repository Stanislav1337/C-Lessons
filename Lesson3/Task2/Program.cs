// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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

