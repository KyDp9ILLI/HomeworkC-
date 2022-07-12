using System;

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива:");
int sizeArr = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива:");
int minimal = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива:");
int maximal = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int[] AdvArray(int[] arr)
{
    // int len = 0;
    // if (arr.Length % 2 == 0)
    // {
    //     len = arr.Length / 2;
    //     int[] newArr = new int[len];
        
    // }
    // else
    // {
    //     len = arr.Length/2 + 1;
    //     int[] newArr = new int[len];
    //     newArr[len] = arr[len];
    // }
    int len = 0;
    if (arr.Length % 2 == 0 ) len = arr.Length / 2;
    else len = arr.Length/2 + 1;
    int[] newArr = new int[len];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 > 0 ) newArr[len-1] = arr[len-1];
    return newArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ",");
        else
            Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int[] array = CreateArrayRndInt(sizeArr, minimal, maximal);
// PrintArray(array);
int[] newArray = AdvArray(array);
PrintArray(newArray);