using System;

class Test {
    public static void Main(string[] args) {
        object num = 10;
        switch(num) {
            case int:
                Console.WriteLine("Integer");
                break;
            case double:
                Console.WriteLine("Double");
                break;
            case string:
                Console.WriteLine("String");
                break;
            default:
                Console.WriteLine("Unknown Type");
                break;
        }
        string result = num switch {
            int => "Integer",
            double => "Double",
            string => "Float",
            _ => "Unknown Type",
        };
        Console.WriteLine(result);
    }
}