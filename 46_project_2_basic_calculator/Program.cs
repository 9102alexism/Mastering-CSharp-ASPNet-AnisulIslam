using System;

class Program {
    static void Main(string[] args) {
        int num1, num2;
        char op;

        Console.Write("Enter an operation: ");
        op = Convert.ToChar(Console.ReadLine() ?? "%");

        Console.Write("Enter number 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch(op) {
            case '+':
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case '/':
                if(num2 == 0) {
                    Console.WriteLine("Can't divide by zero");
                }
                else {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                }
                break;
            default:
                Console.WriteLine("Invalid Operation");
                break;
        }
    }
}