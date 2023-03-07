// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

static double[,] printArray(int m, int n)
{
    double[,] arr = new double[m, n];
    var rand = new Random();
    
    for (int i = 0; i < m; i++)
    {    for (int j = 0; j < n; j++)
        {
            arr[i,j] = Math.Round(rand.NextDouble(), 1);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return arr;
}

printArray(3, 4);