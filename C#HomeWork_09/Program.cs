

/*
// Задача 64: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

//recurrent method of number output
string ValueTask(int m, int n)
{
    //stop point
    if (n <= m)
    {
        return n.ToString();
    }
    else
    {
        return m + ", " + ValueTask(m + 1, n);
    }
}

//data request
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}
//output of the result
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}


int numM = ReadData("Enter number M: ");
int numN = ReadData("Enter number N: ");
string res = (numM < numN) ? (ValueTask(numM, numN)) 
: (ValueTask(numN, numM));
PrintData("row of numbers: ", res);
*/



/*
// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//the recurrent method of adding numbers
int SumRec(int m, int n)
{
    //stop point
    if (m >= n) return n;
    return m + SumRec(m + 1, n);
}
//data request
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}
//output of the result
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int numM = ReadData("enter number M: ");
int numN = ReadData("enter number N: ");
int result = (numM < numN) ? (SumRec(numM, numN))
: (SumRec(numN, numM));
//int result = SumRec(numM, numN);
PrintData("the result of addition = ", result.ToString());
*/



/*
// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

//calculating the Ackerman function
int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0)
    {
        return FunctionAkkerman(m - 1, 1);
    }
    if (n > 0 && m > 0)
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    }
    return FunctionAkkerman(m, n);
}

//data request
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}
//output of the result
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int numM = ReadData("enter number M: ");
int numN = ReadData("enter number N: ");
int result = FunctionAkkerman(numM, numN);
PrintData("Answer is - ", result.ToString());
*/