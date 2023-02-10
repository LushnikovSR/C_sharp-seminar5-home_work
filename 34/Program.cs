// // Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите значение длинны массива: ");
int lenArray = int.Parse(Console.ReadLine()!);
int minValueArray = 100;
int maxValueArray = 1000;
int[] workArray = GetArray(lenArray, minValueArray, maxValueArray);
Console.Write($"[{String.Join(", ", workArray)}] -> {GetCountEvenNum(workArray)}");

int GetCountEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
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