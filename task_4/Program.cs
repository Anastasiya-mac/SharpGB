
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

static string findMax(int a, int b, int c)
{
    string result;
    result = a > b && a > c ? Convert.ToString(a) : b > a && b > c ? Convert.ToString(b) : c > a && c > b ? Convert.ToString(c) : "Неверные данные";
    
    return result;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max = " + findMax(a, b, c));