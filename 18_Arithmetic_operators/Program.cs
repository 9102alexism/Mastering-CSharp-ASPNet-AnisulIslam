using System;

class Test {
    public static void Main(string[] args) {
        int number1 = 10;
        int number2 = 3;
        int result;

        result = number1 + number2;
        Console.WriteLine("Addition: " + result);

        result = number1 - number2;
        Console.WriteLine("Subtraction: " + result);

        result = number1 * number2;
        Console.WriteLine("Multiplication: " + result);

        result = number1 / number2;
        Console.WriteLine("Division: " + result);

        double div = (double)number1 / number2;
        Console.WriteLine($"Division: {div:F3}");

        result = number1 % number2;
        Console.WriteLine("Remainder: " + result);
    }
}