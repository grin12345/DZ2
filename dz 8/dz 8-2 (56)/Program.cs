//Задача 54: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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


int [,] array =GetArray (m, n, 0, 10);
PrintArray (array);
Console.WriteLine();
int [] array2 =new int [m];


for (int i = 0; i < array.GetLength(0); i++)
{
  int sumLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    array2 [i] = sumLine;
       
}
Console.WriteLine($"Сумма элементов каждой строки -  {string.Join (", ", array2)}");
int min = 0;
    for (int i = 1; i < array2.Length; i++)
    {
        if (array2[i] < array2[min]) min = i;
    }
Console.WriteLine ($" Номер строки с минимальной суммой  элементов -   {min+1}");