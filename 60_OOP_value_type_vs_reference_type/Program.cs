using System;

class Person {
    public string? name;
    public int age;

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
        int n = 2;
        Console.WriteLine(n);
        
        int m = n;
        m = 7;
        Console.WriteLine(m);

        Console.WriteLine(n);

        Person p1 = new Person("fahim", 30);
        p1.DisplayInfo();

        Person p2 = p1;
        p2.name = "lol";
        p2.age = 57;
        p2.DisplayInfo();

        p1.DisplayInfo();
    }
}