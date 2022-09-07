//// задайте массив
//программа, которая определяет присутствует ли заданное число в массиве
Console.WriteLine ("Введите число ");
int a = int.Parse(Console.ReadLine()); 

int size =8;
int minValue = -9;
int maxValue = 9;
int [] array = new int [size];
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
bool exists = false;
for (int i=0; i< array.Length; i++)
{
   if (array [i]== a)
   {
    exists = true;
    break;
   }
}
if (exists)
{
    Console.WriteLine ("да");
}

else
Console.WriteLine ("нет");
