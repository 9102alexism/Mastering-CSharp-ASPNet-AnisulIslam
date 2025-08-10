using System;

class Test {
    public static void Main(string[] args) {
        double fahrenheit, celsius;

        Console.Write("fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        celsius = (fahrenheit - 32) / 1.8;
        Console.WriteLine($"celsius: {celsius:F2}");
    }
}