// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void NumberSum(int n, int m, int sum)
{
    Console.WriteLine($"{n} {m}");
    if ( n > m)
    {    Console.WriteLine($"Сумма натуральных элементов в промежутке от N до M: {sum}");
    return;

    }
    sum = sum + (n++);
    NumberSum(n, m, sum);

}


Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
NumberSum(n, m, 0);