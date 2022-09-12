// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i,j] +" ");
        }
        Console.WriteLine();
    }
}

int [,] GetArray(int m, int n)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result [i,j] = new Random().Next(0, 10);
        }
    }
    return result;
}

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());


int [,] array =GetArray (m, n);
PrintArray (array);

Console.WriteLine();
Console.WriteLine("Укажите позицию элемента (номер строки) ");
int position = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите позицию элемента (номер столбца) ");
int position1 = int.Parse(Console.ReadLine());

if (position <= m
    && position1 <= n
    && position >= 0
    && position1 >= 0) 
{
    Console.WriteLine("Такое значение есть  " + array [position, position1]);
}
else
{ 
    Console.WriteLine("такого числа нет"); 
}