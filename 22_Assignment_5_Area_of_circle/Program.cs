using System;

class Test {
    public static void Main(string[] args) {
        double radius, circleArea;

        Console.WriteLine("Circle Area Calculator");
        
        Console.Write("Radius: ");
        radius = Convert.ToDouble(Console.ReadLine());

        circleArea = 3.1416 * radius * radius;
        Console.WriteLine($"Circle Area: {circleArea:F2}");
    }
}