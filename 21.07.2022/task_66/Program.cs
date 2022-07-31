// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задайте первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int NaturalNumber(int num1, int num2)
{
 
    if (num1 < num2)
    {
        return num2 + NaturalNumber(num1, num2 - 1);
    }
    if (num1 > num2)
    {
        return num1 + NaturalNumber(num1 - 1, num2);
    }
    if (num1 == num2)
    {
        return num1;
    }
    return 0;
}

Console.WriteLine(NaturalNumber(number1, number2));
