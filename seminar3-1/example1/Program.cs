// обьединение массива

int []arr = new int [3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;

string joinedArray = MyJoin(",", arr);
Console.WriteLine (joinedArray);

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