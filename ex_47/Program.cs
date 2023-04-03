//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int m = 3;
int n = 4;

Random rand = new Random();
double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Math.Round(rand.NextDouble() * 10, 1);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}