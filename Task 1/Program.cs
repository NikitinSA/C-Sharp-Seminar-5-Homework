/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();

int[] array = new int[10];

void PrintRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.Write($"{array[i]} ");
    }
}

int CountPositiveNumberInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

PrintRandomArray(array);
Console.WriteLine();
int result = CountPositiveNumberInArray(array);
Console.Write($"Количество чётных чисел в массиве = {result}");