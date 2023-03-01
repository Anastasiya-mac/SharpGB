// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


static string isEven(int a)
{
    string result;
    result = a % 2 == 0 ? "да" : "нет";
    return result;
}

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isEven(a));
