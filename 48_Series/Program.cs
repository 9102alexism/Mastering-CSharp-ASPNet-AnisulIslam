int num1 = 0, num2 = 1;
for(int i = 1; i <= 10; i++) {
    Console.Write(num1 + " ");
    num2 = num1 + num2;
    num1 = num2 - num1;
}