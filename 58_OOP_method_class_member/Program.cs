using System;

class Person {
    string? name;
    int age;

    public void SetValue(string n, int a) {
        name = n;
        age = a;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program {
    static void Main(string[] args) {
        Person p1 = new Person();
        p1.SetValue("fahim", 30);
        p1.DisplayInfo();
    }
}