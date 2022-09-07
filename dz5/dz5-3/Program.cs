// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size =5;
void FillArray (double [] collection) 
{
        for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().NextDouble()*100;
    }
}

void PrintArray(double [] col)
{
      Console.Write("[");
    for (int index = 0; index < col.Length; index++)
    {
        Console.Write(col[index] + ", ");
    }
    Console.WriteLine ("]");
 }

double []array = new double [size];
FillArray (array);
PrintArray (array);
double maxNumber = array[0];
double minNumber = array[0];
for (int i=0; i< array.Length; i++)
{
   if ( maxNumber<array[i])
   {
    maxNumber=array[i];
   }
   if (minNumber>array[i])
   {
   minNumber=array[i];
   }
}
double result = maxNumber -  minNumber;
Console.WriteLine ("Разница между максимальным и минимальным элементами: " + result);
