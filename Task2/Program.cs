/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array = GetArray(5, -100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Сумма нечетных элементов массива = {GetSumOdd(array.Length, array)}");

int GetSumOdd(int size, int[] array )
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue);
    }
    return result;
}

