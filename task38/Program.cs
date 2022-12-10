
// task38 Задайте массив вещественных (дробных) чисел. Найдите разницу между
// максимальным и минимальным элементами массива
// [3, 7, 22, 2, 78 ] ->76

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (20 - 10) + 10, 2);
}

double MaxArray(double[] array)
{
    double MaxArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (MaxArray < array[i])
            MaxArray = array[i];
    }
        return MaxArray;
}

double MinArray(double[] array)
{
    double MinArray = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (MinArray > array[i])
            MinArray = array[i];
    }
        return MinArray;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Изначальный массив: [{string.Join(" , ", array)}]");
Console.WriteLine($"Результат: {MaxArray(array) - MinArray(array)}");
