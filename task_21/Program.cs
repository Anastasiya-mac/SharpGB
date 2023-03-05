// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

static double distanceBetween(int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double temp = Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2);
    double result = Math.Round(Math.Sqrt(temp), 2);
    return result;
}


Console.WriteLine("Введите координаты первой точки: x, y, z");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: x, y, z");
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(distanceBetween(Ax, Ay, Az, Bx, By, Bz));