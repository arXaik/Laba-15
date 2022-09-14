//Петросян вариант 16
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
double S = Math.Sqrt(Math.Cos(4 * Math.Pow(y,2))+ 7.151 );
Console.WriteLine($"S={S:F2}");