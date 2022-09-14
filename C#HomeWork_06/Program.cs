/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Numbers (int size){            // m = size array
    int a;
    int res = 0;
    for (int i = 1; i <= size; i++){
        Console.WriteLine($"enter number {i} please: ");
        a = Convert.ToInt32(Console.ReadLine());
        if(a > 0) res++;
    }
    Console.WriteLine($"numbers of positive numbers = {res}");
}
Console.WriteLine("enter number size: ");
int num = Convert.ToInt32(Console.ReadLine());
Numbers(num);
*/




/*
// // Задача 43: Напишите программу, которая найдёт точку пересечения
// // двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// // значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Coordinates();

void Coordinates(){
    Console.WriteLine("input K1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input B1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input K2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input B2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1)/(k1 - k2);
    double y = x * k1 + b1;
Console.WriteLine($"the intersection pooint has coordinates X-({x}) ; Y-({y}) ");
}

*/


















