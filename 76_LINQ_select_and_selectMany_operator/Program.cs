// LINQ - Language Integrated Query

class Person {
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? BloodGroup { get; set; }
}

class Test {
    static void Main(string[] args) {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        var squaredNumbers = numbers.Select(num => num * num);

        foreach(var item in squaredNumbers) {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");

        List<Person> people = new List<Person>() {
            new Person() { Name = "Anisul", Age = 34, BloodGroup = "A+" },
            new Person() { Name = "Bob", Age = 3, BloodGroup = "B+" },
            new Person() { Name = "Nusrat Jahan", Age = 21, BloodGroup = "B-" }
        };

        var names = people.Select(person => person.Name);
        foreach(var item in names) {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");

        var nameBloodGroup = people.Select(person => (person.Name, person.BloodGroup));
        // (string? Name, string? BloodGroup)[] nameBloodGroup = people.Select(person => (person.Name, person.BloodGroup)).ToArray();
        foreach(var item in nameBloodGroup) {
            Console.WriteLine(item.Name + " " + item.BloodGroup);
        }

        Console.WriteLine();

        List<List<int>> nestedLists = new List<List<int>>() {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 4, 5 },
            new List<int>() { 6, 7, 8 },
            new List<int>() { 9 }
        };

        var flattedList = nestedLists.SelectMany(list => list);
        foreach(var item in flattedList) {
            Console.Write(item + " ");
        }
    }
}