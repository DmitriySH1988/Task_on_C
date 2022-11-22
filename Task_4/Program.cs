Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for(int i = 2; i <= num; i = i+2)
    Console.Write($"{i} ");