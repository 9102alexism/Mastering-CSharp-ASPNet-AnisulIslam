using System;

class Test {
    public static void Main(string[] args) {
        int number;
        Console.Write("Enter a number between 1-10: ");
        number = Convert.ToInt32(Console.ReadLine());

        switch(number) {
            case int num when num < 1 || num > 10:
                Console.WriteLine("Number out of Range");
                break;
            case int num when num % 2 == 0:
                Console.WriteLine("Even");
                break;
            case int num when num % 2 != 0:
                Console.WriteLine("Odd");
                break;
            default:
                break;
        }

        string result = number switch {
            int num when num < 1 || num > 10 => "Number out of Range",
            int num when num % 2 == 0 => "Even",
            int num when num % 2 != 0 => "Odd",
            _ => "",
        };
        Console.WriteLine(result);

        result = number switch {
            int num when num >= 1 && num <= 10 => num % 2 == 0 ? "Even" : "Odd",
            _ => "Number out of Range",
        };
        Console.WriteLine(result);
    }
}