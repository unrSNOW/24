Console.WriteLine("введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("введите y:");
double y = double.Parse(Console.ReadLine());
if (y == Math.Pow(x, 2) - 2) Console.WriteLine("принадлежит");
else if (y == x) Console.WriteLine("принадлежит");
else if (y == (-x)) Console.WriteLine("принадлежит");
else Console.WriteLine("не принадлежит");
