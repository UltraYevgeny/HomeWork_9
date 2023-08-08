/*
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
void List(int n)
{
    if (n > 0) 
    {
    Console.Write(n + " ");
    n--;
    List(n);
    }
}

Console.Write("Enter number: ");
List(Convert.ToInt32(Console.ReadLine()));
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int Sum(int numM, int numN)
{
    if (Math.Min(numM, numN) != Math.Max(numM, numN))
    {
    return Sum (Math.Min(numM, numN) + 1, Math.Max(numM, numN)) + Math.Min(numM, numN);
    }
    else return Math.Max(numM, numN);
    
}

Console.Write("Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int summa = Sum(m, n);

Console.Write("Summa of digits: " + summa);
*/


/*
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int Akkir(int m, int n)
{
    if (m == 0)
    return n+1;
    if (m > 0 && n == 0)
    return Akkir (m - 1, 1);
    if (m>0 && n>0)
    return Akkir(m-1, Akkir(m, n-1));
    else return 0;
}

Console.Write("Enter positive number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter positive number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkirman = Akkir(m, n);

if (Akkirman > 0)
Console.Write("Function of Akkirman result: " + Akkirman);
if (Akkirman == 0)
Console.Write("Error!");

