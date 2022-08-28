// На вход принимает цифру, обозначающую день недели, и проверяет является ли этот день выходным
Console.WriteLine("Введите число, обозначающий день недели: ");
int a = int.Parse(Console.ReadLine());
while (a > 7)
{
    Console.WriteLine("Введите число от 1 до 7");
   a = int.Parse(Console.ReadLine());
}
if (a >= 1 && a <= 5)
{
    Console.WriteLine("будний день");
}
else if (a>=6 && a<8)
{
    Console.WriteLine("выходной день");
}
