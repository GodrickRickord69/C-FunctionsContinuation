/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] array = GetArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");

int EvenNumbers = 0;
int Number = 0;

foreach(int el in array)
{
    Number = el % 2;
    EvenNumbers += Number > 0 ? 0 : 1;
}
Console.WriteLine($"Количество четных чисел массива = {EvenNumbers}");


int [] GetArray(int size, int MinValue, int MaxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(MinValue, MaxValue);
    }
    return result;
}

