string[] names = { "fahim", "sakib", "abrar" };

for(int i = 0; i < names.Length; i++) {
    Console.WriteLine(names[i]);
}

Console.WriteLine("\n\n");

foreach(string name in names) {
    Console.WriteLine(name);
}