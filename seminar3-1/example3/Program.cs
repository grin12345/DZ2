/// замена элементов массива
//положит заменить на отриц
//отрицательные на положит

int size =5;
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
for (int i=0; i< array.Length; i++)
{
    array[i] =  array[i]*-1;
}


Console.WriteLine (MyJoin(",", array));

