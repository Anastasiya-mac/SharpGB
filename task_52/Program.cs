// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


static void avgForColumn()
{
    int n = 3, m = 4, i, j;
    float[] res = new float[m];
    int[,] arr = new int[n, m];
    var rand = new Random();
    
    for (i = 0; i < n; i++)
    {    for (j = 0; j < m; j++)
        {
            arr[i,j] = rand.Next(-10, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

    for (j = 0; j < m; j++)
    {   float temp = 0;
        for (i = 0; i < n; i++)
        {
            temp += arr[i,j];
        }
        //Console.WriteLine(temp + " ");
        res[j] = temp/n;
    }

    Console.WriteLine("Результат: ");
    for (i = 0; i < m; i++)
        Console.Write(res[i] + " ");

    Console.WriteLine();
    
}

avgForColumn();