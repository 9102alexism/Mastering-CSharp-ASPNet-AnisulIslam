using System;

class Test {
    public static void Main(string[] args) {
        try {
            Console.Write("How many elements you want: ");
            int size = int.Parse(Console.ReadLine() ?? "");

            int[] numbers = new int[size];

            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) {
                Console.Write($"Enter element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine() ?? "");
                sum += numbers[i];
            }

            int max = numbers[0];
            int min = numbers[0];

            for(int i = 0; i < numbers.Length; i++) {
                if(max < numbers[i]) max = numbers[i];
                if(min > numbers[i]) min = numbers[i];
            }

            Console.Write($"Max Element: {max}\n");
            Console.Write($"Min Element: {min}\n");
            Console.Write($"Sum of the array: {sum}\n");
            Console.Write($"Average: {(((float)sum / numbers.Length)):F2}\n");
        }
        catch(FormatException) {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
        catch(OverflowException) {
            Console.WriteLine("Input is too large or small.");
        }
        catch(OutOfMemoryException) {
            Console.WriteLine("Out of memory. Can't create array with such large dimensions.");
        }
        catch(Exception ex) {
            Console.WriteLine($"An error occured: {ex.Message}");
        }
    }
}