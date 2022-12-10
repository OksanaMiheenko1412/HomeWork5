// task34 задайте массив заполненный случайными положительными трехзначными
// числами. Наапишите программу, которая покажет количество четных чисел в 
// массиве. [345, 897, 568, 234] ->2

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[n]; 
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]"); 
Console.WriteLine($"Результат: {ReleaseArray(array)}");


