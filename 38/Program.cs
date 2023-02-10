// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите значение длинны массива: ");
int lenArray = int.Parse(Console.ReadLine()!);
int minValueArray = -100; // указано отрицательное число -> по условию работаем с вещественными числами
int maxValueArray = 100;
float[] workArray = GetArray(lenArray, minValueArray, maxValueArray);
float maxV = GetMaxMinElementArray(workArray)[0];
float minV = GetMaxMinElementArray(workArray)[1];
Console.Write($"[{String.Join(", ", workArray)}] -> {maxV - minV}");

float[] GetMaxMinElementArray(float[] array)
{
    float max = 0;
    float min = 0;
    if (array[0] > array[1])
    {
        max = array[0];
        min = array[1];
    }
    else
    {
        max = array[1];
        min = array[0];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    float[] result = {max, min};
    return result;
}

float[] GetArray(int size, int minValue, int maxValue)
{
    float[] array = new float[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}