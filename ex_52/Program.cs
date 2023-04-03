//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

int rows = array.GetLength(0);
int columns = array.GetLength(1);

for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    double average = sum / rows;
    Console.WriteLine($"Среднее арифметическое для столбца {j}: {average}");
}

