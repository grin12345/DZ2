/// по заданному номеру четверти показывает диапозон возожных координат точек в этой четверти

Console.WriteLine("Введите № четверти");
int quarter = int.Parse(Console.ReadLine());

switch (quarter)
{
case 1:
    {
    Console.WriteLine ("x>0, y>0");
    break;
    }
case 2:
{
    Console.WriteLine("x<0, y>0");
    break;
}
case 3:
{
    Console.WriteLine("x>0, y<0");
    break;
}
case 4:
{
    Console.WriteLine("x<0, y<0");
    break;
}
}
