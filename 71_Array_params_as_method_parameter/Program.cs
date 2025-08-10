using System;

class Test {
    static int Sum(params int[] numbers) {
        int sum = 0;
        
        foreach(int num in numbers) {
            sum += num;
        }

        return sum;
    }

    public static void Main(string[] args) {
        Console.WriteLine(Sum(1, 5, 10, 4));
    }
}