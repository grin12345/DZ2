// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

int [,] array =GetArray (m, n, 0, 9);
PrintArray (array);
Console.WriteLine();
int firstRowIndex = 0; //индекс первой строк
int lastRowIndex = array.GetLength(0) -1;//индекс последней строки
for (int j = 0; j < array.GetLength(1); j++)
{
   
    int temp = array [firstRowIndex, j];
    array [firstRowIndex,j] = array [lastRowIndex, j];
    array [lastRowIndex, j] = temp;
}
PrintArray (array);