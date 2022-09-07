// задайте массив из 12 элементов, заполненный случайными числами из промежутка -9, 9.
// найдите сумму отрицателный и положительный элементов массива.

int size =12;
int minValue = -9;
int maxValue = 9;
int []array = new int [size];
for (int i= 0; i< array.Length -1; i++)
{
    array [i] = new Random().Next (minValue, maxValue+1);
}

string joinedArray = MyJoin(",", array);
Console.WriteLine (joinedArray);// вывод массива

string MyJoin (string delimeter, int [] array)
{
    string result = ""; //создаем пустую строку 
    for (int i=0; i< array.Length -1; i++)
    {
        result = result+array[i]+ delimeter;
    }
     result = result+array[array.Length -1]; //вывести последний элемент без цикла - без последней запятой
     return result;
}

int negativeNumSum = 0;
int positiveNumSum = 0;
foreach (int el in array)
{
    negativeNumSum+=el < 0? el:0;
    positiveNumSum+=el > 0? el:0;
    /* if (el < 0)
    {
        negativeNumSum+= el; 
   }
    if (el >0)
    {
        positiveNumSum+=el;
    } */
}
Console.WriteLine ("Сумма положительных чисел =" +positiveNumSum);
Console.WriteLine ("Сумма отрицательный чисел =" +negativeNumSum);