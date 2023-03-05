// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

static void arrayEnter()
{
    var temp = Console.ReadLine()?.Split(' ').ToArray()!;
    
    for (int i = 0; i < 8; i++)
        Console.Write(temp[i] + " ");
    
}

arrayEnter();