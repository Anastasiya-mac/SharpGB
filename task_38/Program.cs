// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


static double sumNotEvenPosition()
{
    int N = 10;
    double result = 0;

    double[] array = new double[N];
    var rand = new Random();
    for (int i = 0; i < N; i++)
        array[i] = rand.NextDouble()*5;
    
    double mini = array[0], maxi = array[0];
    
    for (int i = 0; i < N; i++)
    {   if (array[i] < mini)
            mini = array[i];
        else if (array[i] > maxi)
            maxi = array[i];
    }

    for (int i = 0; i < N; i++)
        Console.Write(Math.Round(array[i], 2) + " ");
    
    Console.WriteLine();
    result = maxi - mini;
    return Math.Round(result, 2);
}

Console.WriteLine(sumNotEvenPosition());

