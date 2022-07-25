// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


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

void FindElement(int[,] arr, int line, int column)
{
    if (line< arr.GetLength(0)+1 && column <arr.GetLength(1)+1
    )
    {
        Console.WriteLine($"Число находящееся в строке {line} и столбце {column} является {arr[line-1, column-1]}");
    }
    else Console.WriteLine("Нет нужного элемента");
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

int[,] array = CreateMatrixRndInt(sizeM, sizeN, minimal, maximal);
PrintMatrix(array);
Console.WriteLine("Введите нужную строку");
int lin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите нужный столбец");
int col = Convert.ToInt32(Console.ReadLine());
FindElement(array, lin, col);
