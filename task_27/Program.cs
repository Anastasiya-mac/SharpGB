// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

static int sumOfNum(int num)
{
    int result = 0;

    for (int i = 1; num/i > 0; i *= 10)
        result += (num / i) % 10;
    
    return result;
}

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumOfNum(num));