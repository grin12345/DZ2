// выведите  первые N Фибоначи
//Первые 2 числа 0 и 1
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int [] arr = new int [n];
arr[0] = 0;
arr[1] = 1;
for (int i=2; i<n; i++)
{
    arr[i] = arr[i-1] +arr[i-2];
}
Console.WriteLine(string.Join (", " , arr));
