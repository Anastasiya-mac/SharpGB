// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

static string secondNum(int number)
{
    string result = (number < 100 || number > 999) ? "число должно быть трехзначным" : "->" + (number % 10) % 10;
    return result;
}

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(secondNum(number));