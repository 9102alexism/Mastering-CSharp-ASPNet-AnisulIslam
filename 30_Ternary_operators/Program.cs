using System;

class Test {
    public static void Main(string[] args) {
        int num1 = 10;
        int num2 = 25;

        int large = num1 > num2 ? num1 : num2;
        Console.WriteLine(large);
    }
}