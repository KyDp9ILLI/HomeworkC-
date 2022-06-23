// Задача 5: Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int min = -a;

while (min <= a)
{
    Console.Write(min + " ");
    min +=1;
}


//Если вводить отрицательные числа, то вот так надо

// int min = 0;

// if (a>0) min = -a;
// else min = a;

// while (min <= Math.Abs(a))
// {
//     Console.Write(min + " ");
//     min +=1;
// }
