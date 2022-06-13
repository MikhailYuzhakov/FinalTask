Console.Clear();
Console.WriteLine("Введите слова или сочетания букв через пробел: ");
String[] size = Console.ReadLine().Split().ToArray();

Console.Clear();
Console.WriteLine("Введенные Вами слова: ");
for (int i = 0; i < size.Length; i++) {
    Console.Write(size[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Введенные Вами слова с длинною больше или равной 3: ");
for (int i = 0; i < size.Length; i++) {
    if (size[i].Length <= 3) {
        Console.Write(size[i] + " ");
    }
}