// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
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

int imin = 0;
int jmin = 0;
//int min = array [0, 0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < array [imin, jmin])
        {
            imin = i;
            jmin = j;
        }
    }
}
Console.WriteLine();
Console.WriteLine(imin+ " " + jmin);
/* for (int i = 0; i < array.GetLength(0); i++)
{
    if (i == imin)
    {
        continue;
    }
    for (int j = 0; j < array.GetLength(1); j++)
   {
        if (j == jmin)
        {
            continue;
        }
        Console.Write(array[i, j] + " ");
    }
    
        Console.WriteLine();
}
    

 */