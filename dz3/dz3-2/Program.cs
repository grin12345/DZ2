/// принимает на вход координаты2 точек т находит расстояние между ними в 3Д пространстве

Console.WriteLine("Введите коордтнаты точки А");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите коордтнаты точки B");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());

Console.WriteLine (Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)));
