try {
    throw new Exception("LOL");
}
catch(Exception ex) {
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex);
}
finally {
    Console.WriteLine("GoodBye!");
}

/*
    NullReferenceException
    ArgumentNullException
    ArgumentOutOfRangeException
    IndexOutOfRangeException
    InvalidOperationException
    FormatException
    DivideByZeroException
    OverflowException
    IOException
    FileNotFoundException

    isNullorEmpty()
    isNullorWhiteSpace()


Top 10 Common C# Exceptions
============================

1. NullReferenceException
   - Happens when: You access a member on a null object
   - Example: obj.ToString() when obj == null

2. ArgumentNullException
   - Happens when: You pass null to a method that doesn't allow it
   - Example: DoSomething(null)

3. ArgumentOutOfRangeException
   - Happens when: You pass a value outside the valid range
   - Example: list[10] when list.Count == 5

4. IndexOutOfRangeException
   - Happens when: You access an invalid array index
   - Example: arr[5] when arr.Length == 3

5. InvalidOperationException
   - Happens when: An operation is not valid for the current object state
   - Example: dequeue from an empty queue

6. FormatException
   - Happens when: A string is in the wrong format for parsing
   - Example: int.Parse("abc")

7. DivideByZeroException
   - Happens when: You divide a number by zero
   - Example: int x = 10 / 0

8. OverflowException
   - Happens when: Arithmetic operation exceeds the type's range
   - Example: checked { int x = int.MaxValue + 1; }

9. IOException
   - Happens when: A general input/output error occurs
   - Example: reading from a locked or corrupted file

10. FileNotFoundException
    - Happens when: A file does not exist or path is incorrect
    - Example: File.ReadAllText("missing.txt")

*/