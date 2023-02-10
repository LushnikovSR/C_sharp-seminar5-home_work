// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Введите значение длинны массива: ");
int lenArray = int.Parse(Console.ReadLine()!);
int minValueArray = 1;
int maxValueArray = 100;
int[] workArray = GetArray(lenArray, minValueArray, maxValueArray);
Console.Write($"[{String.Join(", ", workArray)}] -> {SumEvenIndexElementArray(workArray)}");

int SumEvenIndexElementArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}