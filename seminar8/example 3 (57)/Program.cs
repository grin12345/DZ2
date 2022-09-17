// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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

int [] array2 = new int [array.GetLength(0) * array.GetLength(1)];
int z = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array2[z] = array [i, j];
        z++;
    }
}
    
Console.WriteLine (string.Join (", ", array2));
void SelectionSort (int[] array)
{
       for (int i=0; i <array.Length - 1; i++)
    {
         int min=i;
         for (int j = i+1; j< array.Length; j++)
         {
             if (array[j] < array[min]) min=j;
         } 
        int temp = array[i];
        array[i] = array [min];
        array[min] = temp;        
    }
}
SelectionSort (array2); 
Console.WriteLine (string.Join (", ", array2));
int el = array2 [0];
int count = 0;
Console.WriteLine ();
for (int i = 0; i < array.Length; i++)
  {
    if (array2[i] == el) 
    {
        count++;
    }
    else
    {
      Console.WriteLine(el + " встречается " + count );
      el = array2[i];
      count = 1;
    }
  }

 Console.WriteLine(el + " встречается " + count );
  