// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

static int isPositive()
{
    int M = 8, result = 0;
    int[] array = new int[M];
    Console.WriteLine("Введите последовательность из " + M + " чисел:");
    for (int i = 0; i < M; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
            result++;
    }
    Console.WriteLine("Из них больше 0:");
    return result;
}

Console.WriteLine(isPositive());