using System;

class Test {
    public static void Main(string[] args) {
        // Implicit / Automatic conversion
        // char -> int -> long -> float -> double -> decimal
        // Explicity / Manual Conversion
        // double -> float -> long -> int -> char

        int salary = 2547;
        Console.WriteLine(Convert.ToString(salary));
        Console.WriteLine(Convert.ToDouble(salary));

        Console.Write(Convert.ToChar((salary/1000) + 48));
        Console.Write(Convert.ToChar(((salary/100)) % 10 + 48));
        Console.Write(Convert.ToChar(((salary/10)) % 10 + 48));
        Console.WriteLine(Convert.ToChar((salary % 10) + 48));
    }
}