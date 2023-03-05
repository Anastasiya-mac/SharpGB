// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

static int sumNotEvenPosition()
{
    int N = 10, result = 0;
    int[] array = new int[N];
    var rand = new Random();
    
    for (int i = 0; i < N; i++)
    {
        array[i] = rand.Next(-10, 10);
        if (i % 2 != 0)
            result += array[i];
    }

    for (int i = 0; i < N; i++)
        Console.Write(Convert.ToInt32(array[i]) + " ");
    
    Console.WriteLine();
    return result;
}

Console.WriteLine(sumNotEvenPosition());

