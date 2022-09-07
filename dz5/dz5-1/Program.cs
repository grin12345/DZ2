// задайте массив , заполненный случайными положительными трехзначными числами
// показать количечество четный чисел в массиве

int size =12;
void FillArray (int [] collection) 
{
        for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
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
int positiveCount= 0;

for (int i=0; i< array.Length; i++)
{
   if (array[i]% 2==0)
   {
    positiveCount++;
   }
}

Console.WriteLine ("количество четных чисел в массиве: " + positiveCount);