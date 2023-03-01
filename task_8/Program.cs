// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


static string allEven(int n)
{
    string result = "";
    for (int i = 1; i <= n; i++)
        result += i % 2 == 0 ? i + " ," : "";

    return result;
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(allEven(n));
