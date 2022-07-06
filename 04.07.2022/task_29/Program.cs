// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] arr = new int[8];
Random rand = new Random();

void ArrayChar(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = rand.Next(0,100);
    }
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
PrintArray(arr);
ArrayChar(arr);
Console.WriteLine();
PrintArray(arr);