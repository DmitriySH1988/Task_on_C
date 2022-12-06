//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
void InputArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}
double ReleaseArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
    return max - min;
}

Console.Clear();
Console.Write("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {ReleaseArray(array)}");
