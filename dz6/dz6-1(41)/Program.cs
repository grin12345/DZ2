// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите количество чисел");
int m = int.Parse(Console.ReadLine());
int [] array = new int[m];

void InputNumbers(int []array)
{
for (int i = 0; i < m; i++)
  {
    Console.Write ("Введите число: ");
    array[i] = int.Parse(Console.ReadLine());
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
InputNumbers (array);
PrintArray (array);
int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
    count++; 
    }
  }
  
  Console.WriteLine ("Введено чисел больше 0: " + count);