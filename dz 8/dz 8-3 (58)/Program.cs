// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(minValue,  maxValue + 1);
        }
    }
    return result;
}

Console.WriteLine("Введите количество строк в первой матрице");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в первой матрице");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк во второй матрице");
int m1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов во второй матрице");
int n1 = int.Parse(Console.ReadLine());


int [,] array =GetArray (m, n, 0, 10);
PrintArray (array);
Console.WriteLine();

int [,] array1 =GetArray (m1, n1, 0, 10);
PrintArray (array1);
Console.WriteLine();

int[,] array2 = new int[m,n1];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2 [i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array2[i, j] += array[i, k] * array1[k, j];
        }
        
    }
}

Console.WriteLine("Произведение двух матриц: ");
PrintArray(array2);
