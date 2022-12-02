// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int count = n;
for(int i = 1; i < m; i++)
    {
        count*=n;   
    }
Console.WriteLine(count);