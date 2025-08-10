for(int i = 0; i < 100; i++) {
    if(i == 50) break;
    Console.Write(i + " ");
}

Console.WriteLine("\n");

for(int i = 0; i < 100; i++) {
    if(i == 50) continue;
    Console.Write(i + " ");
}