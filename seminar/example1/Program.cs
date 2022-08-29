// gпринимает на вход координаты  (x y), причем х  и у не равны 0 и выдает № четверти
void VyvodChetvert (int chetvert) 
{
Console.WriteLine ("точка принадлежит четверти №  " + chetvert);
}
Console.WriteLine("Введите x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y");
int y = int.Parse(Console.ReadLine());
if (x>0 && y>0)
{
    VyvodChetvert (1);
}
if (x<0 && y>0)
{
    VyvodChetvert (2);
}
if (x>0 && y<0)
{
    VyvodChetvert (3);
}
if (x<0 && y<0)
{
    VyvodChetvert (4);
}