// Task 1
Console.Clear();
Console.Write("Введите 1-ое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine()); // Entering a number
Console.Write("Введите 2-ое число: ");
int num_2 = Convert.ToInt32(Console.ReadLine()); // Entering a number

if (num_1 > num_2)
    Console.Write($"Максимальное число = {num_1}\nМинимальное число = {num_2}");
else if (num_1 < num_2)
    Console.Write($"Максимальное число = {num_2}\nМинимальное число = {num_1}");
else
    Console.WriteLine("Числа равны");