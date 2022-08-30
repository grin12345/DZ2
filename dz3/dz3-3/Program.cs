//// принимает на вход число N и выводит таблица кубов (5-> 1, 8, 27, 64, 125)
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());
n = Math.Abs (n);
int i = 1;
while (i <= n)
{
    Console.Write (Math.Pow (i, 3) + "," );
    i++;
}