// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк первой матрицы:");
int sizeM1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы:");
int sizeN1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элементов первой матрицы:");
int minimal1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов первой матрицы:");
int maximal1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк второй матрицы:");
int sizeM2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы:");
int sizeN2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элементов второй матрицы:");
int minimal2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элементов второй матрицы:");
int maximal2 = Convert.ToInt32(Console.ReadLine());

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

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    var resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
        Console.WriteLine();
    }

    return resultMatrix;
}
int[,] firstArray = CreateMatrixRndInt(sizeM1, sizeN1, minimal1, maximal1);
PrintMatrix(firstArray);
Console.WriteLine();
int[,] secondArray = CreateMatrixRndInt(sizeM2, sizeN2, minimal2, maximal2);
PrintMatrix(secondArray);
Console.WriteLine();
if (firstArray.GetLength(1) == secondArray.GetLength(0))
{
    Console.WriteLine("Произведение матриц равно:");
    int[,] result = MultiplicationMatrix(firstArray, secondArray);
    PrintMatrix(result);
}
else
    Console.WriteLine("Невозможно выполнить умножение");
