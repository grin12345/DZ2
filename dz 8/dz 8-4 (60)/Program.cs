// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write(matrix[i, j, k] + " (" + i + j + k + " )" );
        }

        Console.WriteLine();
    }
     
}

/* int[,,] GetArray(int m, int n, int z)
{
    int[,,] result = new int[m, n, z];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(10, 99);
               
            }
        }
    }
    return result;
}
Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = int.Parse(Console.ReadLine());

int [,,] array =GetArray (x,y,z); */
int[,,] array = { { {11, 20}, {12, 30} }, { {22, 40}, {32, 50} } };

PrintArray (array);
Console.WriteLine();


