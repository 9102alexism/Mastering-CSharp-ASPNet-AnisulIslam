string text = "hello";

Console.WriteLine(text.Length);
Console.WriteLine(text[0]);
Console.WriteLine(string.IsNullOrEmpty(text));
Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());
Console.WriteLine(text.Trim());
Console.WriteLine(text.Substring(1));
Console.WriteLine(text.Substring(2, 2));
Console.WriteLine(text.Insert(5, " world!"));
Console.WriteLine(text.Remove(2));
Console.WriteLine(text.Replace("hello", "bye"));
Console.WriteLine(text.Contains("llo"));
Console.WriteLine(new string(text.Reverse().ToArray()));
Console.WriteLine(string.Join(" ", text.Split("ll")));