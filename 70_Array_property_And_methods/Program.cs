int[] numbers = { 1, 2, 3, 4, 5 };

Console.WriteLine("Length of array: " + numbers.Length);
Console.WriteLine("Rank of the array: " + numbers.Rank);
Console.WriteLine("Max of the array: " + numbers.Max());
Console.WriteLine("Min of the array: " + numbers.Min());
Console.WriteLine("Sum of the array: " + numbers.Sum());
Console.WriteLine("Avg of the array: " + numbers.Average());

Array.Sort(numbers);
Console.Write("Sort: ");
foreach(int num in numbers) {
    Console.Write(num + " ");
}

Console.WriteLine();

Array.Reverse(numbers);
Console.Write("Reverse: ");
foreach(int num in numbers) {
    Console.Write(num + " ");
}

Console.WriteLine();

Console.WriteLine("Index of item: " + Array.IndexOf(numbers, 3));
Console.WriteLine("Exists: " + Array.Exists(numbers, number => number == 4));

int[] copy = new int[10];
Array.Copy(numbers, copy, numbers.Length);
Console.Write("Copy: ");
foreach(int num in copy) {
    Console.Write(num + " ");
}

Console.WriteLine();

Array.Clear(copy, 0, copy.Length);
Console.Write("Clear: ");
foreach(int num in copy) {
    Console.Write(num + " ");
}