using System;

class Test {
    public static void Main(string[] args) {
        Console.Write("Enter a day of the week: ");
        string? day = Console.ReadLine();

        if(day != null) {
            day = day.ToLower();   
        }
        else {
            Console.WriteLine("NULL string!");
            return;
        }

        switch(day) {
            case "friday":
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
                Console.WriteLine("Weekday");
                break;
            case "saturday":
            case "sunday":
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }
}