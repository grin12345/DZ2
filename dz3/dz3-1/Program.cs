// принимаена вход 5-ти значное число и проверяется, является ли оно палиндромом
Console.WriteLine("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
while (a < 10000 || a > 100000)
{
    Console.WriteLine("Введите пятизначное число: ");
   a = int.Parse(Console.ReadLine());
}
int b = a % 10;
int c = a / 10 % 10;
int d = a /1000% 10;
int e = a/10000;

if (b==e && c==d)
{
    Console.WriteLine("является палиндромом");
}
else
{
    Console.WriteLine(" не является палиндромом");
}
