// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трёх значное число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine((num % 100) / 10);

