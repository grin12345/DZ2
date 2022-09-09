// преобразовывает десятичное число в двоичное
Console.WriteLine("Введите число");
int num10 = int.Parse(Console.ReadLine());
int a=0;
int i =0;
string b = "";
while (num10>=1)
{
    a= num10%2;
    b=a+b;

    num10 = num10/2;
}
Console.WriteLine(b);