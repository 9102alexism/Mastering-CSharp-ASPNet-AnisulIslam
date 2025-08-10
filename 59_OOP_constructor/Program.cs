using System;

class Person {
    string? name;
    int age;

    public Person() {
        name = "lol";
        age = 67;
    }

    public Person(string n, int a) {
        name = n;
        age = a;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program {
    static void Main(string[] args) {
        Person p1 = new Person("fahim", 30);
        p1.DisplayInfo();

        Person p2 = new Person();
        p2.DisplayInfo();
    }
}