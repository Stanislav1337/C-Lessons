// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*\

/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да*/

// Console.WriteLine("Введите целое число");
// bool isInt = int.TryParse(Console.ReadLine(), out int num);
// if (!(isInt)) {
//     Console.WriteLine("Вы ввели неподходящее число");
// } else {
//     if (IsPallindrom(num)){
//         Console.WriteLine($"Число {num} является палиндромом");
//     } else {
//         Console.WriteLine($"Число {num} не является палиндромом");
//     }
// }

// int Md (int num){
//     if (num >= 0){
//         return num;
//     } else {
//         return (num * (-1));
//     }
// }
// int SecNum (int num) {    
//     int range = 0;
//     int tempToRange = Md(num);  
//     while (tempToRange != 0){
//         tempToRange = tempToRange / 10;
    
   
//     }
//     return range;
// }
// int[] FillingArray (int[] array, int num){
//     int[] arr = array;
//     for (int i = array.Length-1; i >= 0; i--){
//         arr[i] = num%10;
//         num = num/10;
    
//     }
//     return arr;
// }

// bool IsPallindrom (int num){
//     int[] array = new int [SecNum(num)];
//     array = FillingArray(array, num);
//     for (int i = 0; i < array.Length; i++){
    
//         if (!(array[i]==(array[(array.Length-1)-i]))) return false;
//     }
//     return true;
// }






