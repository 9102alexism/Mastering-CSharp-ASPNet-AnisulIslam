using System;

class Test {
    public static void Main(string[] args) {
        Console.WriteLine("Temperature Converter Started");
        Console.WriteLine("Choose 1. Fahrenheit to Celsius");
        Console.WriteLine("Choose 2. Celsius to Fahrenheit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch(choice) {
            case 1:
                Console.Write("Enter Fahrenheit Temperature: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) / 1.8;
                Console.WriteLine("Temperature in Celsius: " + celsius.ToString("F2"));
                break;
            case 2:
                Console.Write("Enter Celsius Temperature: ");
                celsius = Convert.ToDouble(Console.ReadLine());
                fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}