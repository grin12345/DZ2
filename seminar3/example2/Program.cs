// принимает на вход число и выдает количество цифр в числе
Console.WriteLine ("Введите число A: ");
int a = int.Parse(Console.ReadLine()); 
int CountNumber (int arg)
{
    int resul = 0;
    arg =Math.Abs(arg);
    while (arg>0)
    {
        resul++;
        arg=arg/10;
    }
    return resul;
}
int count = CountNumber (a);
Console.WriteLine  ("Ответ: для числа " + a + " количество цифр ->" + count);
