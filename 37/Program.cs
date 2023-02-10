// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

Console.Clear();
Console.Write("Введите размер массива для последующего его заполнения с клавиатуры: ");
int lenArray = int.Parse(Console.ReadLine()!);
int[] newArray = { };
if (lenArray > 0){
    newArray = GetArray(lenArray);
    Console.Write($"[{String.Join(", ", newArray)}] -> ");
    Console.Write($"{String.Join(", ", GetSumArrayPairs(newArray))}");
}
else if (lenArray == 0){
    Console.Write("Вы создали пустой массив. Конец программы.");
}
else{
    Console.Write("Вы ввели не корректное значение. Конец программы.");
}


int[] GetArray(int len)
{
    int[] array = new int[len];
    Console.Write("Введите элемент массива и нажмите Entre, повторяйте до полного заполнения массива: ");
    for (int i = 0; i < len; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int[] GetSumArrayPairs(int[] array)
{
    int[] sumArray = {};
    int j = array.Length - 1;
    int halfLen = array.Length / 2;
    if (array.Length % 2 == 0){  // отделение массива с четным числом элеменотов от массива с нечетным числом элементов
        sumArray = new int[halfLen];
        for (int i = 0; i < halfLen; i++){
            sumArray[i] = array[i] + array[j];
            j--;
        }
    }
    else{
        sumArray = new int[halfLen + 1];
        for (int i = 0; i < halfLen; i++){
            sumArray[i] = array[i] + array[j];
            j--;
        }
        sumArray[halfLen] = array[halfLen]; // добавление в массив с суммами чисел элемента из базового массива без пары
    }
    return sumArray;
}