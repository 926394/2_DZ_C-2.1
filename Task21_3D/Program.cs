// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки А ");
Console.Write("Введите координату xA: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату yА: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату zА: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B ");
Console.Write("Введите координату xB: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату yB: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату zB: ");
double z2 = double.Parse(Console.ReadLine()!);

double subx = (x1-x2);
double sqrx = Math.Pow(subx, 2);

double suby = (y1-y2);
double sqry = Math.Pow(suby, 2);

double subz = (z1-z2); //diffy
double sqrz = Math.Pow(subz, 2);

double sum = sqrx + sqry + sqrz;


// Console.WriteLine("Расстояние между двумя точками: " +sqrz);
Console.WriteLine("Расстояние между двумя точками: "+Math.Round(Math.Sqrt(sum),2));