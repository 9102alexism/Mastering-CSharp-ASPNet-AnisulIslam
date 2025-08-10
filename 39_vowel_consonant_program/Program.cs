char letter;

Console.Write("Enter any letter: ");
letter = Convert.ToChar(Console.ReadLine()!);
letter = char.ToLower(letter);

if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u') {
    Console.WriteLine($"{letter} is a vowel");
}
else {
    Console.WriteLine($"{letter} is a consonant");
}