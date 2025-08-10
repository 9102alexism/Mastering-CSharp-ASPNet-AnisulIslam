int factorial = 1;

for(int i = 1; i <= 5; i++) {
    factorial *= i;
}
Console.WriteLine(factorial + " ");

factorial = 1;
for(int i = 5; i >= 1; i--) {
    factorial *= i;
}
Console.Write(factorial + " ");