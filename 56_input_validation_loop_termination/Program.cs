using System;

class Test {
    static int CalculateSquare(int num) {
        return num * num;
    }

    static void Main(string[] args) {
        do {
            Console.Write("Enter a number 1 to 10 or write quit to exit: ");
            string input = Console.ReadLine() ?? "";
            input = input.ToLower().Trim();
            
            if(input == "quit") {
                Console.WriteLine("Thanks for using our app. Goodbye!");
                break;
            }

            if(!int.TryParse(input, out int num)) {
                Console.WriteLine("Enter a valid input. Please give a number.");
                continue;
            }

            if(!(num >= 1 && num <= 10)) {
                Console.WriteLine("Enter a number between 1 to 10.");
                continue;
            }

            Console.WriteLine($"Square of {num}: {CalculateSquare(num)}");
        } while(true);
    }
}