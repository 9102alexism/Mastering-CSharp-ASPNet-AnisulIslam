using System;

class Student {
    public string? Name { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string RollNumber { get; private set; }

    public Student(string name, DateTime dateOfBirth, string rollNumber) {
        ValidateInputs(name, dateOfBirth, rollNumber);
        Name = name;
        DateOfBirth = dateOfBirth;
        RollNumber = rollNumber;
    }

    private static void ValidateInputs(string name, DateTime dateOfBirth, string rollNumber) {
        if(dateOfBirth > DateTime.Now) {
            throw new ArgumentException("Date of birth can't be in the future.");
        }
        if(string.IsNullOrWhiteSpace(name)) {
            throw new ArgumentNullException("Name can't be empty.");
        }
        if(string.IsNullOrWhiteSpace(rollNumber)) {
            throw new ArgumentNullException("Roll Number can't be empty.");
        }
        if(dateOfBirth == default) {
            throw new ArgumentException("Date of birth can't be null.");
        }
    }

    private int CalculateAge() {
        DateTime today = DateTime.Today;
        int age = today.Year - DateOfBirth.Year;
        return DateOfBirth.Date > today.AddYears(-age) ? --age : age;
    }

    /*
    public int Age {
        get { return CalculateAge(); }
    }
    */

    public int Age => CalculateAge();

    public void PrintDetails() {
        Console.WriteLine(
            $"Name: {Name}, Date Of Birth: {DateOfBirth.ToString("d")}, Roll Number: {RollNumber}, Age: {Age}"
        );
    }
}

class Program {
    public static void Main(string[] args) {
        try {
            Student student1 = new Student(
                "Fahim", new DateTime(1994, 10, 29), "CSE101"
            );
            Student student2 = new Student(
                "Sakib", new DateTime(1994, 4, 25), "CSE101"
            );

            Console.WriteLine("Student Details: ");
            Console.WriteLine("------------------------------");
            
            student1.PrintDetails();
            student2.PrintDetails();
        }
        catch(ArgumentException ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}