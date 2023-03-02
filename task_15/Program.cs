// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

static string isWeekend(int number)
{
    string result = (number == 6 || number == 7) ? "да" : "нет";
    return result;
}

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isWeekend(number));