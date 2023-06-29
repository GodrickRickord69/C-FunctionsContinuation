/*Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62*/

int[] array = GetArray(5, -100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");

int Max = array[0];
int Min = array[0];

for(int i = 0; i < size; i++)
{
    if (array[i])
}
Console.WriteLine($"Количество четных чисел массива = {EvenNumbers}");



int [] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size - 1; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue);
    }
    return result;
}
