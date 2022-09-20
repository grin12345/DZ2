// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()); 

int SumNumbers(int m, int n)
{
    if (m <= n)
        return m + SumNumbers(m + 1, n);
    else return 0;
}
Console.WriteLine (SumNumbers(m, n));