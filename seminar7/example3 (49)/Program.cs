// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

int [,] array =GetArray (m, n, 0, 9);
PrintArray (array);

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ( i %2 ==0 && j%2==0)
            {
                array [i,j] = array [i,j]*array [i,j];
            }
        }
    }

PrintArray (array);