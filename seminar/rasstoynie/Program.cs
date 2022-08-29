/// принимает на вход координаты2 точек т находит расстояние между ними в 2Д пространстве

Console.WriteLine("Введите коордтнаты точки А");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите коордтнаты точки B");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
//int e = (x1-x2) * (x1-x2);
//int f = (y1-y2) * (y1-y2);
//
//double res = Math.Sqrt (e+f);
Console.WriteLine (Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)));

