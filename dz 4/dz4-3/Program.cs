﻿//задает массив из 8 элементов и выводит их на экран
void FillArray (int [] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
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
    Console.Write("]");
 }

 int []array = new int [8];
 FillArray (array);
 PrintArray (array);