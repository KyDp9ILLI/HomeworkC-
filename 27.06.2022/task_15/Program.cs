// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, которое будет обозначать день недели:");
int a = Convert.ToInt32(Console.ReadLine());

string Week(int day)
{
    switch(day){
    case 1: case 2: case 3: case 4: case 5: return "Не выходной";
    case 6: case 7: return "Выходной";
    default : return "Некоректно введено число";
    }
}

Console.WriteLine(Week(a));