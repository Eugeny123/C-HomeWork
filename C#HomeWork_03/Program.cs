/*
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom(){
    Console.WriteLine("enter number please ");        //this is the second solution
    int num = Convert.ToInt32(Console.ReadLine());    //new Random().Next(10000, 100000)
    int n1 = num / 10000;                             //Console.WriteLine("our number : "+ num);
    int n2 = (num / 1000) % 10 ;
    int n4 = (num % 100) / 10;
    int n5 = num % 10;
    if (n1 == n5 && n2 == n4){
        Console.WriteLine("Aw! this palindrom!");
    }
    else{
        Console.WriteLine("Oh no! this number isn't palindrom!");
    }
}
Palindrom();

*/


/*
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double Distance(){
    Console.WriteLine("Enter the coordinate X1 -");
    double x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the coordinate y1 -");
    double y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the coordinate z1 -");
    double z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the coordinate X2 -");
    double x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the coordinate y2 -");
    double y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the coordinate z2 -");
    double z2 = Convert.ToInt32(Console.ReadLine());
    
    double Q = (x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1);
    double result = Math.Sqrt(Q);                     //this is the root extraction method
    return result;
}
double number = Distance();
Console.WriteLine("distance =" + number);

*/



/*
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Cube(){
    Console.WriteLine("Enter number please - ");
    int num = Convert.ToInt32(Console.ReadLine());
    int count = 1;
    while(count <= num){
        Console.Write("  "+count * count * count);
        count++;
    }
}
Cube();

*/


