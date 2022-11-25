// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)
Console.WriteLine("Понедельник - трудный рабочий день");
else if (num == 2)
Console.WriteLine("Вторник - рабочий день");
else if (num == 3)
Console.WriteLine("Среда - рабочий день");
else if (num == 4)
Console.WriteLine("Четверг - рабочий день");
else if (num == 5)
Console.WriteLine("Пятница - рабочий день, осталось совсем немножко");
else if (num == 6)
Console.WriteLine("Суббота - Уррааа!!!ВЫХОДНОЙ!!!");
else if (num == 7)
Console.WriteLine("Воскресенье - Уррааа!!!ВЫХОДНОЙ!!!");
else
Console.WriteLine("Введите корректное число от 1 до 7 :");