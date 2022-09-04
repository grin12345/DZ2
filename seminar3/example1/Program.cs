// На вход принимает число А и выдает сумму чисел от 1 до А
void GetSumNums (int number)
{
    int sum = 0;
    for (int i=0; i<=number; ++i)
    {
        sum+=i;
    }
    Console.WriteLine (sum);
}

Console.WriteLine ("Введите число A: ");
int a = int.Parse(Console.ReadLine()); 

GetSumNums(a);