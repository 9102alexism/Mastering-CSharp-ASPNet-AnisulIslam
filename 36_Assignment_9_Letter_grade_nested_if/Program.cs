double num;

Console.Write("Enter number between 0-100: ");
num = Convert.ToDouble(Console.ReadLine());

if(num >= 90 && num <= 100) {
    Console.WriteLine("A");
}
else if(num >= 80) {
    Console.WriteLine("B");
}
else if(num >= 70) {
    Console.WriteLine("C");
}
else if(num >= 60) {
    Console.WriteLine("D");
}
else if(num >= 0) {
    Console.WriteLine("F");
}
else {
    Console.WriteLine("Invalid Number");
}

if(num < 60 && num >= 0) {
    Console.WriteLine("F");
}
else if(num < 70) {
    Console.WriteLine("D");
}
else if(num < 80) {
    Console.WriteLine("C");
}
else if(num < 90) {
    Console.WriteLine("B");
}
else if(num <= 100) {
    Console.WriteLine("A");
}
else {
    Console.WriteLine("Invalid Number");
}