// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] GetMatrix(int rows, int columns)
// {
//     double[,] matrix = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int l = 0; l < columns; l++)
//         {
//             matrix[i, l] = i + l;
//         }
//     }
//     return matrix;
// }

// double[,] matrix = GetMatrix(3, 4);

// PrintMatrix(matrix);

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             System.Console.Write($" {matrix[i,l]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int SetNumber(string numberName = "")
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
//     int[,] matrix = new int[rows, columns];

//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int l = 0; l < columns; l++)
//         {
//             matrix[i, l] = random.Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;

// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int l = 0; l < matrix.GetLength(1); l++)
//         {
//             System.Console.Write($" {matrix[i, l]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = SetNumber("rows");
// int columns = SetNumber("columns");

// int min = SetNumber("min value");
// int max = SetNumber("max value");

// int[,] matrix = GetMatrix(rows, columns, maxValue: max, minValue: min);
// PrintMatrix(matrix);

// int SetPosition(string position = "") //Запрашиваем индексы числа
// {
//     Console.Write($"Enter number {position}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int i = SetNumber("i");
// int l = SetNumber("l");

// if (i <= matrix.GetLength(0) && l <= matrix.GetLength(1))
// {
//     System.Console.WriteLine($"число в двумерном массиве = {matrix[i, l]}");
// }
// else
// {
//     System.Console.WriteLine($"числа с таким индексом в двумерном массиве не существует");
// }

// System.Console.WriteLine(matrix[i, l]);

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int SetNumber(string numberName = "")
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minValue, int maxValue) //двумерный массив
{
    int[,] matrix = new int[rows, columns];

    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = random.Next(minValue, maxValue + 1);
        }
    }
    return matrix;

}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write($" {matrix[i, l]} ");
        }
        System.Console.WriteLine();
    }
}

int rows = SetNumber("rows");
int columns = SetNumber("columns");

int min = SetNumber("min value");
int max = SetNumber("max value");

int[,] matrix = GetMatrix(rows, columns, maxValue: max, minValue: min);
PrintMatrix(matrix);

for (int l = 0; l < matrix.GetLength(1); l++)
{
    double ArithmeticMean;
    int SumNumber = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SumNumber = (SumNumber + matrix[i, l]);
    }
    ArithmeticMean = SumNumber / rows;
    Console.Write(ArithmeticMean + "; ");
}
