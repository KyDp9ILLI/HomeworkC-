// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

int SumOddIndex (int[] arr)
{
    int sumNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 >0)
        {
            sumNum += arr[i];
        }
    }
    return sumNum;
 
}

int[] array = CreateArrayRndInt(sizeArr, minimal, maximal);
PrintArray(array);
int summa = SumOddIndex(array);
Console.WriteLine("Сумма элементов, стоящих на нечетных позициях = " + summa);