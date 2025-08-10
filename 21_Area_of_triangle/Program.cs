using System;

class Test {
    public static void Main(string[] args) {
        double baseLength, height, triangleArea;

        Console.WriteLine("Triangle Area Calculator");
        
        Console.Write("Base: ");
        baseLength = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height: ");
        height = Convert.ToDouble(Console.ReadLine());

        triangleArea = 0.5 * baseLength * height;
        Console.WriteLine($"Triangle Area: {triangleArea:F2}");
    }
}