// Дополнительная задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
for (int i = 0; i < rows; i++) 
{
    for (int j = 0; j <= (rows - i); j++)
    {
        Console.Write(" "); //выводим пробелы
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write(factorial(i)/(factorial (j)* factorial (i-j)));
        Console.Write(" ");
    }
    Console.WriteLine();
}
double factorial (int a)
{
    double x= 1;
    for (int i = 1; i <= a; i++) 
    {
        x*=i;
    }
    return x;
}
