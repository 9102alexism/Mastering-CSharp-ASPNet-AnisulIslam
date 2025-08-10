using System;

class Test {
    public static void Main(string[] args) {
        string? studentName;
        int studentAge;

        Console.Write("Enter your name: ");
        studentName = Console.ReadLine();

        Console.Write("Enter your age: ");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine("Age: " + studentAge + " years old");
    }
}