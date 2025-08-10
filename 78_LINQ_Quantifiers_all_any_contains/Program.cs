class Person {
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Test {
    public static void Main(string[] args) {
        List<Person> people = new List<Person>() {
            new Person() { Name = "Fahim Shakil", Age = 30 },
            new Person() { Name = "Sakib Shahrier", Age = 25 },
            new Person() { Name = "Fariha Rashid", Age = 20 },
        };

        bool allAdults = people.All(person => person.Age >= 18);
        Console.WriteLine($"Are all people adults? {allAdults}");

        bool anyTeenager = people.Any(person => person.Age < 20);
        Console.WriteLine($"Is there any teenager? {anyTeenager}");

        bool containsFahim = people.Select(person => person.Name).Contains("Fahim Shakil");
        Console.WriteLine($"Does this collection contain \"Fahim\" ? {containsFahim}");
    }
}