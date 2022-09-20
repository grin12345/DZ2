// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
 //M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine()); 

string PrintNumber (int m, int n)
{
    if (m<=n)
    
        return $"{m}" +  PrintNumber (m+1, n) ;
            
    else return string.Empty;
 }
Console.Write (PrintNumber (m, n));
