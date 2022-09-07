// задайте массив , заполненный случайными числами
// найти сумму элем6ентов, стоящих на нечетных позициях

int size =5;
void FillArray (int [] collection) 
{
        for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-100, 100);
    }
}

void PrintArray(int [] col)
{
      Console.Write("[");
    for (int index = 0; index < col.Length; index++)
    {
        Console.Write(col[index] + ", ");
    }
    Console.WriteLine ("]");
 }

int []array = new int [size];
FillArray (array);
PrintArray (array);
int sumElement = 0;

for (int i=0; i< array.Length; i++)
{
   if (i % 2==0)
   {
    sumElement = sumElement+ array[i];
   }
}

Console.WriteLine ("Сумма элементов, стоящих на нечетных позициях: " + sumElement);
