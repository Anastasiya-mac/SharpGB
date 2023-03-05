// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

static string isPolindrom(int num)
{
    string temp = Convert.ToString(num);
    string result = ((temp[0]+temp[1]+temp[2]) == (temp[4]+temp[3]+temp[2])) ? "да" : "нет";
    return result;
}

int num = num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isPolindrom(num));
