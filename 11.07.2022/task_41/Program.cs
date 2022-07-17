using System;
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел:");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < arr.Length - 1)
            Console.Write(arr[i] + ";");
        else
            Console.Write(arr[i] + "]");
    }
    Console.WriteLine();
}

int CountPos (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) count++;
    }
    return count;
}

int[] array = CreateArray(size);
PrintArray(array);
Console.WriteLine("Количество чисел больше 0 равно " + CountPos(array));