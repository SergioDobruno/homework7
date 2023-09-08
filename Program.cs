// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GetMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = i + l;
        }
    }
    return matrix;
}

double[,] matrix = GetMatrix(3, 4);

PrintMatrix(matrix);

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write($" {matrix[i,l]} ");
        }
        System.Console.WriteLine();
    }
}