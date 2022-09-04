/// Напишите цикл который принимает нв вхыд 2 число АиБ 
// и возводит число А в нвтуральную степень Б
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int c = 1;
for (int i=1; i<=b; i++)
{
    c = c*a;
  }
Console.WriteLine(c);
