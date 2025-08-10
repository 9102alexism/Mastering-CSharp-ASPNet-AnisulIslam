using System;

class Test {
    public static void Main(string[] args) {
        int num1, num2, num3, sum;
        double avg;

        Console.Write("number1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("number2: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("number3: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2 + num3;
        avg = (double)sum / 3;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Avg: " + avg.ToString("F3"));
    }
}