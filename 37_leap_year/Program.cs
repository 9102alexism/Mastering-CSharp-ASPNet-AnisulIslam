int year;

Console.Write("Enter year: ");
year = Convert.ToInt32(Console.ReadLine());

if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) {
    Console.WriteLine("Leap");
}
else {
    Console.WriteLine("Not Leap");
}