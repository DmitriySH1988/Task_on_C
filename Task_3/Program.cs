Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()); // Entering a number

if (num % 2 == 0)
    Console.Write($"Число {num} является чётным");
else
    Console.Write($"Число {num} является не чётным");
