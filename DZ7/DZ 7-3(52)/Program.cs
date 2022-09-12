// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
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

for (int j = 0; j < array.GetLength(1); j++)
{
      double sum = 0;
      for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine (sum / m);
}