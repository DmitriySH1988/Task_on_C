// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
    Console.Clear();
    Console.Write("Введите кол-во цифр в массиве: ");
    int elementsCount = int.Parse(Console.ReadLine());
    int[] array = new int[elementsCount];
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"\nВведите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
        if (array[i] >=0)
        count++;
    }

    Console.WriteLine($"Вывод массива: [{string.Join(", ", array)}] - чисел больше 0 = {count}");
