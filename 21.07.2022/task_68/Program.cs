﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Задайте первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine(Akkerman(number1,number2));