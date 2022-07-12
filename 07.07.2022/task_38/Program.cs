// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите размер массива:");
int sizeArr = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива:");
int minimal = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива:");
int maximal = Convert.ToInt32(Console.ReadLine());

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.Next(min, max + 1) + rnd.NextDouble(),1);
    }
    return arr;
}

void PrintArray(double[] arr)
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

double DiffMaxMinElem(double[] arr)
{
    double MinElem = arr[0];
    double MaxElem = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < MinElem)
            MinElem = arr[i];
        if (arr[i] > MaxElem)
            MaxElem = arr[i];
    }
    return MaxElem - MinElem;
}

double[] array = CreateArrayRndInt(sizeArr, minimal, maximal);
PrintArray(array);
double diff = DiffMaxMinElem(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diff}");
