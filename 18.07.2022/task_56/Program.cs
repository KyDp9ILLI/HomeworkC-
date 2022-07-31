// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк:");
int sizeN = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов:");
int sizeM = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элементов массива:");
int minimal = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов массива:");
int maximal = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("|");
            if (j < arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j], 3} | ");
            else
                Console.Write($"{arr[i, j], 3} | ");
        }
        Console.WriteLine();
    }
}

void SummLine(int[,] arr)
{
    int[] sum = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum[i] += arr[i,j]; 
        }
    }
    int minSum = sum[0];
    int minIndex=0;
    for (int i = 1; i < sum.Length; i++){
        if(sum[i] < minSum){
                minSum = sum[i];
                minIndex = i;
        }
    }
    // for (int i = 0; i < sum.Length; i++)
    // {
    //     Console.Write(sum[i]+" ");
    // }
    Console.WriteLine($"Наименьшая сумма  элементов в {minIndex+1} строке");
}

int[,] array = CreateMatrixRndInt(sizeM, sizeN, minimal, maximal);
PrintMatrix(array);
Console.WriteLine();

SummLine(array);