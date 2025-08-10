using System;

class Test {
    public static void Main(string[] args) {
        int number = 10;
        if(number > 0) {
            Console.WriteLine("Positive Number");
        }
        else if(number < 0) {
            Console.WriteLine("Negative Number");
        }
        else {
            Console.WriteLine("Zero");
        }
    }
}