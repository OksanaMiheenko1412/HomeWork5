// task36 задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов,стоящих на нечетных позициях. [3,7,23,12]->19
// [-4,-6,89,6] ->0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 100);
}

int ReleaseArray(int[] array)
{
    int sumPosition = 0;
    for (int i = 1; i < array.Length; i+=2)
        sumPosition += array[i];
    return sumPosition;    
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Результат: {ReleaseArray(array)}");