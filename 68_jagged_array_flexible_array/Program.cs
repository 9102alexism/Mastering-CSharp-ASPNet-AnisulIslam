int[][] matrix = new int[3][] {
    new int[] { 1, 2, 3},
    new int[] { 4, 5, 6},
    new int[] { 7, 8, 9, 10 }
};

for (int i = 0; i < matrix.Length; i++) {
    for (int j = 0; j < matrix[i].Length; j++) {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");

foreach(int[] row in matrix) {
    foreach(int val in row) {
        Console.Write(val + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("\n");

foreach(var row in matrix) {
    foreach(var val in row) {
        Console.Write(val + " ");
    }
    Console.WriteLine();
}