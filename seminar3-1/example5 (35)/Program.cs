/// задайте одномерный массив из 123 случайный чисел
// найдите количество элементов массива, значения которых лежат в отрезке  10 -99
void FillArray (int [] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 124);
        index++;
    }
}

void PrintArray(int [] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
    Console.WriteLine ("]");
 }
int size =123;
int []array = new int [size];
FillArray (array);
PrintArray (array);

int counter = 0;
for (int i=0; i< array.Length; i++)
{
   if (array[i]>=10 && array[i]<100)
   {
    counter++;
   }
}

Console.WriteLine (counter);
