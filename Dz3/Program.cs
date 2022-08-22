// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double [,] a = new
double[1, 5];
Random random = new Random();
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = random.NextDouble() * 100;
        Console.Write("{0,6:F2} ", a[i, j]);
    }
    Console.WriteLine();
}