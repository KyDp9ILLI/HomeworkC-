Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

// int a = 1;
// while (a<=n)
// {
//     Console.WriteLine(Math.Pow(a,3) + " ");
//     a++;
// }
Console.WriteLine("Таблица кубов");
Console.WriteLine("-------------------");

for (int i = 1; i<=n; i++)
{
    Console.WriteLine($"|{i} в кубе = |{i*i*i,4} |");
}
Console.WriteLine("-------------------");