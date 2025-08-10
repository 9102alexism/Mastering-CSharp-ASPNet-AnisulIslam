using System;

class Test {
    public static void Main(string[] args) {
        double fahrenheit, celsius;

        Console.Write("celsius: ");
        celsius = Convert.ToDouble(Console.ReadLine());

        fahrenheit = (celsius * 1.8) + 32;
        Console.WriteLine($"fahrenheit: {fahrenheit:F2}");
    }
}