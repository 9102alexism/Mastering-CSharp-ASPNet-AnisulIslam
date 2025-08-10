using System;

class Test {
    static void Add(int num1, int num2) {
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    }

    static void Sub(int num1, int num2) {
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    }

    static void Square(int num) {
        Console.WriteLine($"{num} ^ 2 = {num * num}");
    }

    static void Message(string input) {
        Console.WriteLine(input);
    }

    static void Main(string[] args) {
        Message("Welcome to Calculator");
        Add(10, 20);
        Sub(10, 20);
        Square(10);
        Message("Goodbye");
    }
}