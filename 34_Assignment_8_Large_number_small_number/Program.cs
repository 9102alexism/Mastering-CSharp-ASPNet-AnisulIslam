using System;

class Test {
    public static void Main(string[] args) {
        int num1, num2;

        Console.Write("Enter number 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 > num2) {
            Console.WriteLine("Number 1 is greater than Number 2");
        }
        else if(num1 < num2) {
            Console.WriteLine("Number 2 is greater than Number 1");
        }
        else {
            Console.WriteLine("Number 1 is equal to Number 2");
        }
    }
}