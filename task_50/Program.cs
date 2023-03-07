// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


static string returnValue(int num)
{
    int n = 3, m = 4, i, j;
    string result = "Нет такого элемента";
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
    for (i = 0; i < n; i++)
        for (j = 0; j < m; j++)
        if (num == (i*(n+1)+j)+1)
            return result = "Ваш элемент: " + Convert.ToString(arr[i,j]);

    return result;


}

Console.WriteLine(returnValue(13));