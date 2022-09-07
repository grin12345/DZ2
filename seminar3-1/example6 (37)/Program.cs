/// найдите произведение пар чисел в одномерном массиве
// первой - считается первый и последний элемент массива
//второйи предпоследний
//результат запишите в новом массиве

int size =5;
int minValue = 1;
int maxValue = 10;
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

int [] arrayResult = array.Length %2 == 1? new int [array.Length /2+1]: new int [array.Length /2];
for (int i=0; i< array.Length/2; i++)
{
    int p = array[i] *array [array.Length -(i+1)];
    arrayResult [i] = p;
}
if (array.Length %2 ==1)
{
    arrayResult[arrayResult.Length-1] = array [array.Length/2];
}
Console.WriteLine (MyJoin(",", arrayResult)); 
