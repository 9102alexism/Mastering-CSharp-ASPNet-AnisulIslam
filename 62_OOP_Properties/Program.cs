using System;

class Person {
    private string? name;

    public string Name {
        get { return name ?? ""; }
        set { name = value; }
    }

    public int Age {
        get; set;
    }
}

class Program {
    static void Main(string[] args) {
        Person p1 = new Person();
        p1.Name = "fahim";
        p1.Age = 30;
        
        Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}");
    }
}