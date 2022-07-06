// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int summa = 0;
    while (number > 0)
    {
        summa += number % 10;
        number = number / 10;
    }
    return summa;
}

int sum = SumNumber(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {sum}");