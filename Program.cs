Console.Write("Digite o texto para traduzi-lo: ");
Console.WriteLine(
    Console.ReadLine()!
        .Replace("A", "4")
        .Replace("a", "4")
        .Replace("E", "5")
        .Replace("e", "5")
        .Replace("I", "f")
        .Replace("i", "f")
        .Replace("L", "i")
        .Replace("l", "i")
        .Replace("O", "0")
        .Replace("o", "u")
        .Replace("T", "y")
        .Replace("t", "y")
        .Replace("S", "6")
        .Replace("s", "6")
);
