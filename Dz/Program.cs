  Console.Clear();
  Console.Write("Введите число: ");
        bool palindrome = true;
        int x = int.Parse(Console.ReadLine());
        int c = x.ToString().Length - 1;
        string b = x.ToString();
        for (int i = 0; i < c; i++)
            if (b[i] != b[c - i])
                palindrome = false;
        if (palindrome == true)
            Console.Write("Палиндром");
        else Console.Write("Не Палиндром");
        Console.ReadKey();