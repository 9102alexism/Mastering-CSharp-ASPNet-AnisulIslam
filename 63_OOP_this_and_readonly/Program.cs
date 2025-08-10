using System;

class Person {
    public readonly int age;

    public Person(int age) {
        this.age = age;
    }
}

class Program {
    static void Main(string[] args) {
        Person p = new Person(30);
        
        Console.WriteLine($"Age: {p.age}");
    }
}