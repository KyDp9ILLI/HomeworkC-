// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1

// 9 5 3 2

// 8 4 4 2

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

int[,] SortElement(int[,] arr)
{
    int[,] b = arr;
    int[] temp = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            temp[j] = b[i, j];
        Array.Sort(temp);
        for (int k = 0; k < arr.GetLength(0); k++)
        {
            b[i, k] = temp[k];
        }
    }
    return b;
}

// for (int i = 1; i < arr.GetLength(0); i++)
// {
//     for (int j = 1; j < arr.GetLength(1); j++)
//     {
//         if (arr[i, j-1]>arr[i,j])
//         {
//             int temp = arr[i,j];
//             arr[i,j] = arr[i, j-1];
//             arr[i, j-1] = temp;
//         }
//     }
// }


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
Console.WriteLine();
int[,] sortArray = SortElement(array);
PrintMatrix(sortArray);
