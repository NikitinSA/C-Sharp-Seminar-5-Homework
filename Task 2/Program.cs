/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();

int[] array = new int[7];

void PrintRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 50);
        Console.Write($"{array[i]} ");
    }
}

int TheSumOfElementsWithAnOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = +sum + array[i];
        }
    }
    return sum;
}

PrintRandomArray(array);
Console.WriteLine();
int result = TheSumOfElementsWithAnOddIndex (array);
Console.Write($"Сумма эллементов, стоящих на нечетных позичиях = {result}");