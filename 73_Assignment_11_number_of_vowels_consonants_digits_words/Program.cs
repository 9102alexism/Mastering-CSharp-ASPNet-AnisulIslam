string input = "Hello 123 world!";

Console.WriteLine("Vowel Count: " + input.Count(c => "aeiouAEIOU".Contains(c)));
Console.WriteLine("Consonants Count: " + input.Count(c => Char.IsLetter(c) && !"aeiouAEIOU".Contains(c)));
Console.WriteLine("Digit Count: " + input.Count(c => Char.IsDigit(c)));
Console.WriteLine("Special Character Count: " + input.Count(c => !Char.IsLetterOrDigit(c) && !Char.IsWhiteSpace(c)));
Console.WriteLine("White Space Count: " + input.Count(c => Char.IsWhiteSpace(c)));
Console.WriteLine("Word Count: " + input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length);