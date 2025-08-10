using System;

class Test {
    public static void Main(string[] args) {
        string? studentName;
        int studentAge;
        double studentCgpa;
        bool isRegistered;

        Console.Write("Enter your name: ");
        studentName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int.TryParse(Console.ReadLine(), out studentAge);

        Console.Write("Enter your Cgpa: ");
        double.TryParse(Console.ReadLine(), out studentCgpa);

        Console.Write("Are you registered: ");
        isRegistered = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine($"Name: {studentName}");
        Console.WriteLine($"Agee: {studentAge}");
        Console.WriteLine($"Cgpa: {studentCgpa}");
        Console.WriteLine($"Registered: {isRegistered}");
    }
}