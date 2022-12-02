Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int [elementsCount];
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите элемент массива под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
} 

Console.WriteLine("вывод массива: ");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine($"Результат: [{string.Join(", ", array)}]");

Console.ReadLine();