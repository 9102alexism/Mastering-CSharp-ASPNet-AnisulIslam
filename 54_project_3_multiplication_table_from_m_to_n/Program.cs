Console.Write("Enter start number: ");
int start = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter end number: ");
int end = Convert.ToInt32(Console.ReadLine());

for(int i = start; i <= end; i++) {
    for(int j = 1; j <= 5; j++) {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}