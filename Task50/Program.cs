// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ElementPosition(int[,] matrix)
{
    Console.Write("Введите номер строки массива (c 0): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца массива (c 0): ");
    int m = Convert.ToInt32(Console.ReadLine());
        if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
        Console.Write("Такой позиции в массиве нет");
        else
        Console.Write($"{matrix[n, m]} \t");
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InputMatrix(matrix);
Console.WriteLine();
ElementPosition(matrix);