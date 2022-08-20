/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();

double[] array = new double[7];

void PrintRandomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 50);
        Console.Write($"{array[i]} ");
    }
}

void TheDifferenceBetweenTheMinAndMaxArrayElements(double[] array, double min, double max)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Минимальный элемент массива = {min}, максимальный элемент массива = {max}");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
}

PrintRandomArray(array);
Console.WriteLine();
double min = array[0];
double max = array[1];
TheDifferenceBetweenTheMinAndMaxArrayElements(array, min, max);