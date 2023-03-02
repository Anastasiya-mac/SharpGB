// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

static string secondNum(int number)
{
    string result = (number >= 100 && number <= 999) ? "->" + (number % 10) : "-> третьей цифры нет";
    return result;
}

int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(secondNum(number));