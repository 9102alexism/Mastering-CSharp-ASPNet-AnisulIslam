class Person {
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Test {
    public static void Main(string[] args) {
        int[] numbers = { 5, 8, 2, 3, 1 };
        
        var sortedNumbers = numbers.OrderBy(num => num);
        foreach(var item in sortedNumbers) {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        sortedNumbers = numbers.OrderByDescending(num => num);
        foreach(var item in sortedNumbers) {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");

        List<Person> people = new List<Person>() {
            new Person() { Name = "Fahim Shakil", Age = 30 },
            new Person() { Name = "Sakib Shahrier", Age = 20 },
            new Person() { Name = "Fariha Rashid", Age = 20 },
        };

        var sortedPeople = people.OrderBy(person => person.Age);
        foreach(var item in sortedPeople) {
            Console.WriteLine(item.Name + " " + item.Age);
        }

        Console.WriteLine();

        sortedPeople = people.OrderBy(person => person.Age).ThenBy(person => person.Name);
        foreach(var item in sortedPeople) {
            Console.WriteLine(item.Name + " " + item.Age);
        }
    }
}