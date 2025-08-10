using System;

class Test {
    public static void Main(string[] args) {
        int number1, number2, number3;

        Console.Write("Number1 = ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number2 = ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Number3 = ");
        number3 = Convert.ToInt32(Console.ReadLine());

        if(number1 > number2 && number1 > number3) {
            Console.WriteLine(number1);
        }
        else if(number2 > number1 && number2 > number3) {
            Console.WriteLine(number2);
        }
        else if(number3 > number1 && number3 > number2) {
            Console.WriteLine(number3);
        }
        else {
            Console.WriteLine("All the numbers are equal.");
        }
    }
}