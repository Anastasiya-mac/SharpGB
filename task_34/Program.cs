// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

static int evenNumInArr()
{
    int N = 10, result = 0;
    int[] array = new int[N];
    var rand = new Random();
    for (int i = 0; i < N; i++)
    {
        array[i] = rand.Next(100, 1000);
        if (array[i] % 2 == 0)
            result++;
    }

    for (int i = 0; i < N; i++)
        Console.Write(Convert.ToInt32(array[i]) + " ");
    
    Console.WriteLine();
    return result;
}

Console.WriteLine(evenNumInArr());

