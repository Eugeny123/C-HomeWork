// задача 10: написать программу, которая принимает на вход трехзначное
// число и на выходе показывает вторую цифру этого числа.

/*

int curNum(){
    int num = new Random().Next(100, 1000); //calling a random number
    Console.WriteLine( num);//output number
    int dec = num / 10;//declaring variables
    int result = dec % 10;
    
    return result;
}
Console.WriteLine( curNum()); //calling the function
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine(threeNum());

int threeNum(){
    Console.WriteLine("Enter number, please :");//enter any number
    int num = Convert.ToInt32(Console.ReadLine()); 
    if(num < 100){
        Console.WriteLine("No third number");
        return 0;
    }
    else{
        if(num > 999){
            while(num > 999){
                num = num / 10;
            }
           
        }
        else{
            num = num % 10;  
        }
          
        }
    int result = num % 10;
    return result;
    
}
*/


/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

void WorkWeek(int num){
    if (num >= 1 && num <= 7){
        if(num > 5){
            Console.WriteLine("It's a day off");
        }
        else{
           Console.WriteLine("It's a work day"); 
        }
        
    }
    else{
        Console.WriteLine("It's not a day of the week");
    }
    
}
Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
WorkWeek(number);  
*/



























