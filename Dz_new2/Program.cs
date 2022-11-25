 //Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
        Console.Clear();
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
         if (n <=99) {
        Console.WriteLine($"{n} В Данном числе нет третьей цифры"); 
       } else {
        while (n > 999) 
        n = n / 10;
        count+=n;
        Console.WriteLine(count % 10);
       }
        
     

