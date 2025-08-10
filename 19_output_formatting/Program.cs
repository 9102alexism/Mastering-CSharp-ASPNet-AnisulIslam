using System;

class Test {
    public static void Main(string[] args) {
        int number1 = 10;
        int number2 = 3;
        int result;

        result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");

        result = number1 - number2;
        Console.WriteLine($"{number1} - {number2} = {result}");

        result = number1 * number2;
        Console.WriteLine($"{number1} * {number2} = {result}");

        result = number1 / number2;
        Console.WriteLine($"{number1} / {number2} = {result}");

        double div = (double)number1 / number2;
        Console.WriteLine("{0} / {1} = {2}", number1, number2, div.ToString("F3"));

        result = number1 % number2;
        Console.WriteLine($"{number1} % {number2} = {result}");
    }
}