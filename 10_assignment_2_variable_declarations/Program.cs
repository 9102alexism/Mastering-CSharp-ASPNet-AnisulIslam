using System;

class Test {
    public static void Main(String[] args) {
        string name = "Apple iPhone 14";
        double price = 320.5;
        string category = "smart phone";
        bool available = true;
        int sold = 5;
        Console.WriteLine(name);
        Console.WriteLine($"${price}");
        Console.WriteLine(category);
        Console.WriteLine(available);
        Console.WriteLine(sold);
    }
}