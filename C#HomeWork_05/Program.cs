/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] CreateRandomArray(int size){
    int[] array = new int[size];

    for(int i =0; i < size; i++){
        array[i]  = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array){
    int even = 0;

    for(int i = 0; i< array.Length; i++){
        if (array[i] %2 == 0){     // checking the number is even
            even++;
        }
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();         //it's for beauty
    Console.Write($"{even}");
    Console.WriteLine();         //this is also for beauty ))
}

Console.WriteLine("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size));
*/

/*
// Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateRandomArray(int size){
    int[] array = new int[size];
    for(int i =0; i < size; i++){
        array[i]  = new Random().Next(1, 100);
    }
    return array;
}

void ShowArray(int[] array){
    int sum = 0;

    for(int i = 0; i< array.Length; i++){
       if (i % 2 != 0){
        sum += array[i];
       }
       Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();         
    Console.Write($"{sum}");
    Console.WriteLine(); 
    
}
    
Console.WriteLine("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size));
*/



/*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] CreateRandomArray(int size){
    int[] array = new int[size];
    for(int i =0; i < size; i++){
        array[i]  = new Random().Next(1, 100);
    }
    return array;
}

void ShowArray(int[] array){
    int min = array[0];
    int max = array[0];
    
    for(int i = 0; i< array.Length; i++){
        if( array[i] > max) {
            max = array[i];
        }
        else{
            if(array[i] < min){
                min = array[i];
            }
        }
        Console.Write($"{array[i]}  "); 
    }
    int res = max - min;
    Console.WriteLine();         
    Console.Write($"The difference between {max} and {min} is {res}");
    Console.WriteLine();
}

Console.WriteLine("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
ShowArray(CreateRandomArray(size));

*/




















