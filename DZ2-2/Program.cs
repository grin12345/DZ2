// выводит третью цифру заданного числа, или сообщает, что третьей цифры нет
// На вход принимает трехзначное число и на выходе показывае 2ую цифру этого числа
Console.WriteLine("Введите число: ");
string array = Console.ReadLine();
int a = array.Length;
if (a>2)
{
    Console.WriteLine (array [2]);
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}