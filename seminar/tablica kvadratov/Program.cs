//// принимает на вход число N и выводит таблица квадратов (5-> 1, 4, 9, 16, 25)
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
N = Math.Abs (N);
int i = 1;
while (i <= N)
{
    Console.Write (Math.Pow (i, 2) + "," );
    i++;
}