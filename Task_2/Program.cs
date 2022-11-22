// Task 2
Console.Clear();
Console.Write("Введите 1-ое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine()); // Entering a number
Console.Write("Введите 2-ое число: ");
int num_2 = Convert.ToInt32(Console.ReadLine()); // Entering a number
Console.Write("Введите 3-ое число: ");
int num_3 = Convert.ToInt32(Console.ReadLine()); // Entering a number

if (num_1 > num_2 || num_1 > num_3)
    Console.Write($"Максимальное число = {num_1}");
else if (num_2 > num_2 || num_2 > num_3)
    Console.Write($"Максимальное число = {num_2}");
else if (num_3 > num_2 || num_3 > num_3)
    Console.Write($"Максимальное число = {num_3}");
else
    Console.WriteLine("Числа равны");
