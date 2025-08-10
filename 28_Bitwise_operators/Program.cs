using System;

class Test {
    public static void Main(string[] args) {
        int num1 = 15;
        int num2 = 12;
        int result;

        result = num1 & num2;
        Console.WriteLine("{0} & {1} = {2}", num1, num2, result);

        result = num1 | num2;
        Console.WriteLine("{0} | {1} = {2}", num1, num2, result);

        result = num1 ^ num2;
        Console.WriteLine("{0} ^ {1} = {2}", num1, num2, result);

        result = num1 >> 2;
        Console.WriteLine("{0} >> 2 = {1}", num1, result);

        result = num1 << 2;
        Console.WriteLine("{0} << 2 = {1}", num1, result);

        result = ~num1;
        Console.WriteLine("~{0} = {1}", num1, result);
    }
}