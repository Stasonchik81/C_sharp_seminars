// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. Пример для массива из 5, а не 123 элементов. 
// В своём решении сделайте для 123:
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] myArr = GetRandomArray(123, 1, 100);
PrintArray(myArr);
int x = CountNumbersBetween(myArr, 10, 99);
Console.WriteLine($" => {x}");

int CountNumbersBetween(int[] arr, int minSize, int maxSize)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > minSize && arr[i] < maxSize) count++;
    }
    return count;
}

int[] GetRandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write(" ]");
}