// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i,j] + "     ");
        }
        Console.WriteLine();
    }
}

double [,] GetArray(int m, int n)
{
    double [,] result = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        result [i,j] = new Random().Next(-9,9) + new Random().NextDouble();
        }
    }
    return result;
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

double [,] array =GetArray (m, n);
PrintArray (array);
