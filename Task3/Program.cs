/*Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62*/

int[] array = GetArray(5, 10, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");



int GetDifferenceMinMax(int []array)
{
    int result = 0;
    int Max = array[0];
    int Min = array[0];
    int size = array.Length;

    for (int i = 1; i < size; i++)
    {
        if (Max < array[i])
        {
            Max = array[i];
        }
        if (Min > array[i])
        {
            Min = array[i];
        }
    }
    result = Max - Min;
    return result;
}
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {GetDifferenceMinMax(array)}");


int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue);
    }
    return result;
}
