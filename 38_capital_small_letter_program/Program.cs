char letter;
int asc;

Console.Write("Enter any letter: ");
letter = Convert.ToChar(Console.ReadLine()!);
asc = Convert.ToInt32(letter);

if(asc >= 65 && asc <= 90) {
    Console.WriteLine($"{letter} is a capital letter");
}
else if(letter >= 'a' && letter <= 'z') {
    Console.WriteLine($"{letter} is a small letter");
}