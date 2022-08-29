// по заданному номеру четверти показывает диапозон возожных координат точек в этой четверти

Console.WriteLine("Введите № четверти");
int a = int.Parse(Console.ReadLine());

if (a == 1)
{
    Console.WriteLine("x>0 y>0");
}
if (a ==2)
{
    Console.WriteLine("x<0 && y>0");
}
if (a ==3)
{
    Console.WriteLine("x>0 && y<0");
}
if (a ==4)
{
    Console.WriteLine("x<0 && y<0");
}

while (a>4)
{Console.WriteLine("вветите число от 1 до 4");
   a = int.Parse(Console.ReadLine());
}