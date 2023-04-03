//Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, cols];
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = random.Next(100);
    }
}

Console.Write("Введите значение элемента: ");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool found = false;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (array[i, j] == value)
        {
            Console.WriteLine("Элемент найден на позиции [{0}, {1}]", i, j);
            found = true;
        }
    }
}

if (found == false)
{
    Console.WriteLine("Элемент в массиве не найден");
}

Console.WriteLine();
Console.WriteLine("Массив:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
