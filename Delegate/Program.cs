using System;

delegate double MathOperation(double x, double y, double z);

class Program
{
    static void Main(string[] args)
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        MathOperation min = (x, y, z) => Math.Min(x, Math.Min(y, z));
        MathOperation max = (x, y, z) => Math.Max(x, Math.Max(y, z));
        MathOperation sum = (x, y, z) => x + y + z;
        MathOperation prod = (x, y, z) => x * y * z;
        MathOperation average = (x, y, z) => (x + y + z) / 3.0;

        Console.WriteLine($"Min: {min(a, b, c)}");
        Console.WriteLine($"Max: {max(a, b, c)}");
        Console.WriteLine($"Sum: {sum(a, b, c)}");
        Console.WriteLine($"Prod: {prod(a, b, c)}");
        Console.WriteLine($"Average: {average(a, b, c)}");
    }
}