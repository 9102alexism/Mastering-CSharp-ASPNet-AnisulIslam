using System;

class Person {
    private string? name;
    private int age;

    public void SetName(string s) {
        name = s;
    }
    
    public string GetName() {
        return name ?? "";
    }

    public void SetAge(int a) {
        age = a;
    }
    
    public int GetAge() {
        return age;
    }
}

class Program {
    static void Main(string[] args) {
        Person p1 = new Person();
        p1.SetName("fahim");
        p1.SetAge(30);

        Console.WriteLine($"Name: {p1.GetName()}, Age: {p1.GetAge()}");
    }
}