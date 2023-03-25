// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
//суммой элементов
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

static void minSumOfStr()
{
    int n = 4, i, j, res = 0;
    int[,] arr = new int[n, n];
    int[] sum = new int[n];
    var rand = new Random();
    
    for (i = 0; i < n; i++)
    {   for (j = 0; j < n; j++)
        {
            arr[i,j] = rand.Next(-10, 10);
            Console.Write(arr[i, j] + " ");
            sum[i] += arr[i,j];
        }
        // Console.WriteLine(sum[i]);
        Console.WriteLine();

    }
    int maxx = sum[0];
    for (i = 1; i < n; i++)
    {   
        if (sum[i] < maxx)
        {
            maxx = sum[i];
            res = i;
        }   

    }
    
    res++;
    Console.WriteLine(res);
    
}

minSumOfStr();