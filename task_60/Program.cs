// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


static void sortArr()
{
    int n = 2, m = 2, k = 2, i, j, l, h = 0;
    int[,,] arr = new int[n, m, k];

    int[,] res = new int[n, m];
    var rand = new Random();
    List<int> randomNumbers = new List<int>();
    int number;
    for (i = 0; i < n*k*m; i++)
    {
        do number = rand.Next(11, 99);
        while (randomNumbers.Contains(number));
        randomNumbers.Add(number);
    }

    for (i = 0; i < n; i++)
    {    for (j = 0; j < m; j++)
        {
            for (l = 0; l < k; l++)
            {
                arr[i,j,l] = randomNumbers[h];
                Console.Write(arr[i, j, l] + " (" + j + l + i + ") ");
                h++;
            }
            Console.WriteLine();
        }
    }
    
}

sortArr();