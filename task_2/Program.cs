// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

static string biggerNum(int a, int b)
{   
    string result = "числа равны";
    result = a == b ? result : a > b ? Convert.ToString(a) : Convert.ToString(b);
    return result;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max = " + biggerNum(a, b));