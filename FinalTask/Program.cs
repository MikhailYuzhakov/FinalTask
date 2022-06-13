Console.Clear();
Console.WriteLine("Введите слова или сочетания букв через пробел: ");
String[] size = Console.ReadLine().Split().ToArray();

Console.Clear();
Console.WriteLine("Введенные Вами слова: ");
for (int i = 0; i < size.Length; i++) {
    Console.WriteLine(size[i]);
}

