// LINQ - Language Integrated Query

class Student {
    public string? Name { get; set; }
    public int Score { get; set; }
}

class Test {
    static void Main(string[] args) {
        List<int> numbers = new List<int>() { 1, 2, 3, 5, 7 };
        List<string> words = new List<string>() { "apple", "orange", "banana", "kiwi" };

        var evenNumbers = numbers.Where(num => num % 2 == 0);
        string[] longWords = words.Where(word => word.Length > 4).ToArray();

        Console.WriteLine($"Count of even numbers: {evenNumbers.Count()}");

        if(evenNumbers.Any()) {
            Console.WriteLine("Even numbers: ");

            foreach(var item in evenNumbers) {
                Console.Write($"{item} ");
            }
        }
        else {
            Console.WriteLine("No even numbers found.");
        }

        Console.WriteLine($"\n\nCount of long words: {longWords.Count()}");

        if(longWords.Any()) {
            Console.WriteLine("Long words: ");

            foreach(var item in longWords) {
                Console.Write($"{item} ");
            }
        }
        else {
            Console.WriteLine("No long words found.");
        }

        List<Student> students = new List<Student>() {
            new Student() { Name = "Alice", Score = 75 },
            new Student() { Name = "Bob", Score = 95 },
            new Student() { Name = "Marley", Score = 80 },
            new Student() { Name = "Anisul", Score = 90 },
            new Student() { Name = "Alia", Score = 65 }
        };
        var studentsWithScoreMoreThan80 = students.Where(student => student.Score > 80); 

        Console.WriteLine($"\n\nCount of even numbers: {studentsWithScoreMoreThan80.Count()}");

        if(studentsWithScoreMoreThan80.Any()) {
            Console.WriteLine("studentsWithScoreMoreThan80: ");

            foreach(var item in studentsWithScoreMoreThan80) {
                Console.WriteLine($"{item.Name} {item.Score}");
            }
        }
        else {
            Console.WriteLine("No studentsWithScoreMoreThan80 found.");
        }
    }
}