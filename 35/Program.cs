// Задайте одномерный массив из 123 случайных чисел [0: 1000]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();
int[] StartArray = GetArray(123, 0, 1000);
// Console.Write("Введите число для поиска в массиве: ");
// int[] findArray = new int []
Console.WriteLine($"массив [{String.Join(", ", StartArray)}] -> {GetRange(StartArray)}");

int GetRange(int[] array)
{
    int result = 0;
    foreach(int el in array)
    {
        if (el >9 && el < 100) result += 1;
        else result += 0;
    }
    return result;
}

int[] GetArray(int size, int minV, int maxV)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minV, maxV);
    }
    return array;
}