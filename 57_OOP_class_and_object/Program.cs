using System;

class Person {
    public string? name;
    public int age;
}

class Program {
    static void Main(string[] args) {
        Person p1 = new Person();
        p1.name = "fahim";
        p1.age = 30;

        Console.WriteLine($"Name: {p1.name}, Age: {p1.age}");
    }
}