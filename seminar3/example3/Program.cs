// принимает на вход число N и выдает произведение чисел от  1 до N/
Console.WriteLine ("Введите число N: ");
int n = int.Parse(Console.ReadLine()); 
int pr =1;
      for (int i = 1; i<=n; i++)
       {
        pr=i*pr;
           }
Console.WriteLine  ("Ответ: произведение чисел от 1 до " + n + "  ->" + pr);