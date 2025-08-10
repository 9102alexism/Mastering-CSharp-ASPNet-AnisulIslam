int[] numbers = { 1, 2, 3, 4, 5 };
int[] shallowCopy = numbers;

Console.Write("Before: ");
foreach(var num in numbers) {
    Console.Write(num + " ");
}

Console.WriteLine("");

Console.Write("Before: ");
foreach(var num in shallowCopy) {
    Console.Write(num + " ");
}

Console.WriteLine("\n");
shallowCopy[2] = 10;

Console.Write("After: ");
foreach(var num in numbers) {
    Console.Write(num + " ");
}

Console.WriteLine("");

Console.Write("After: ");
foreach(var num in shallowCopy) {
    Console.Write(num + " ");
}

Console.WriteLine("\n");

int[] deepCopy = new int[shallowCopy.Length];
Array.Copy(shallowCopy, deepCopy, shallowCopy.Length);

Console.Write("Before: ");
foreach(var num in shallowCopy) {
    Console.Write(num + " ");
}

Console.WriteLine("");

Console.Write("Before: ");
foreach(var num in deepCopy) {
    Console.Write(num + " ");
}

Console.WriteLine("\n");

deepCopy[2] = 20;

Console.Write("After: ");
foreach(var num in shallowCopy) {
    Console.Write(num + " ");
}

Console.WriteLine("");

Console.Write("After: ");
foreach(var num in deepCopy) {
    Console.Write(num + " ");
}