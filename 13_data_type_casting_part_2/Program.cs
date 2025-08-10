using System;

class Test {
    public static void Main(string[] args) {
        string input = "10";
        // int result;
        bool isSuccess = int.TryParse(input, out int result);
        Console.WriteLine($"{result}");
        Console.ReadKey();
    }
}