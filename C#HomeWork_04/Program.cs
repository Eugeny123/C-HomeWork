
/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void Exponent(int A, int B){
    int result = A;
    for(int count = 1; count < B; count++){
        result *= A;
    }
    Console.WriteLine($"the number {A} in a power {B} is a equai to {result}");
}

Console.WriteLine("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Exponent(numberA, numberB);

*/



/*
// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


void Amount(int num){

    int quanti = 0;
    for(int i = num; i != 0; i /= 10 ){
        quanti += i % 10;
    }
    Console.WriteLine($"the sum of all digits is {quanti}");
}

Console.WriteLine("Enter number please: ");
int number = Convert.ToInt32(Console.ReadLine());
Amount(number);

*/





/*
// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] CreatRandomArray(int size){
    int[] array = new int[size];   //set the size of the array
    
    for (int i=0; i<size; i++){       
        array[i] = new Random().Next(0,100); // values from 0 to 99
    }
    return array;
} 
 
void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i = 0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}


Console.Write("enter the number of array elements  ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreatRandomArray(size));
*/




































