// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n >= 1)
{
    sum+= n % 10;
    n = (n - n % 10) / 10;
}
Console.WriteLine(sum);