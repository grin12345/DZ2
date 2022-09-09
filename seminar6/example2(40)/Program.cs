//принимает на вход 3 числа и проверяет
// может ли существовать треугольник со сторонами такой длины
//a=b+c
//b=a+c
//c=a+b
Console.WriteLine("Введите длину от А до В");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  длину от B до C");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите длину от C до A ");
int c = int.Parse(Console.ReadLine());

if (a <b + c && c < a + b && b < a + c)
{
    Console.WriteLine("треугольник существует");
}
else
{
    Console.WriteLine("не может существовать такой треугольник");
}


