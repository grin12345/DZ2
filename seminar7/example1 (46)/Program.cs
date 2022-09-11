//задайте двумерный массив размером м*н
//заполните случайными целыми числами
void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix [i,j]);
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
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());

int [,] result =GetArray (rows, columns, 0, 10);
PrintArray (result);