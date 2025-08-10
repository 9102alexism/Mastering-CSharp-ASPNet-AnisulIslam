using System;

class Test {
    public static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0) {
            Console.WriteLine("Even");
        }
        else {
            Console.WriteLine("Odd");
        }
    }
}