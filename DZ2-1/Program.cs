// На вход принимает трехзначное число и на выходе показывае 2ую цифру этого числа
Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
while (a < 100 || a > 999)
{
    Console.WriteLine("Введите трехзначное число: ");
   a = int.Parse(Console.ReadLine());
}
int b = a / 10;
int c = b % 10;
Console.WriteLine(c);
