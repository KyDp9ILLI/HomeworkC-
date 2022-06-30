// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизачное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num/10000>0 && num/10000<10) Console.WriteLine(Palindrom(num));
else Console.WriteLine("Введено некоректное число");

string Palindrom(int a)
{
    if (a / 10000 == a %10 &&  a/1000%10 == a%100/10) return $"Число {a} является палиндромом";
    else return $"Число {a} не является палиндромом";
}

