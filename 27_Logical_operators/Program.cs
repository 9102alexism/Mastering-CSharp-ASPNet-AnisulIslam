using System;

class Test {
    public static void Main(string[] args) {
        Console.WriteLine(8 > 9 && 8 < 9 && 13 > 9);
        Console.WriteLine(!(8 > 9 || 10 < 9 || 13 > 15));
    }
}