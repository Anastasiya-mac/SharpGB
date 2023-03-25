// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

static void sortArr()
{
    int n = 3, m = 4, i, j;
    int[,] arr = new int[n, m];
    int[] str = new int[m];
    int[,] res = new int[n, m];
    var rand = new Random();
    
    for (i = 0; i < n; i++)
    {    for (j = 0; j < m; j++)
        {
            arr[i,j] = rand.Next(-10, 10);
            Console.Write(arr[i, j] + " ");
            str[j] = arr[i,j];

        }
        
        Array.Sort(str);
        Array.Reverse(str);
        for (j = 0; j < m; j++)
        {
            res[i,j] = str[j];
        }
        
    Console.WriteLine();
    }


    Console.WriteLine("Результат: ");
    for (i = 0; i < n; i++)
    {    for (j = 0; j < m; j++)
        {
            Console.Write(res[i, j] + " ");
        }
        Console.WriteLine();
    }
    
}

sortArr();