// See https://aka.ms/new-console-template for more information
Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int Max1 = 0;
int Max2 = 0;
while (n != 0)
{
    if (n >= Max1 || n > Max2)
        (Max1, Max2) = (n, Max1);
    Console.WriteLine($"{Max1}-Первое макисмальное значение.\n{Max2}-Второе максимальное значение");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("end");
