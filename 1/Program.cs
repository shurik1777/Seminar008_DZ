/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/// <summary>
/// Этот метод заполняет двумерный массив,
/// числами от min до max.
/// </summary>
/// <param name="rows"> Количество строк. </param>
/// <param name="cols"> Количество столбцов. </param>
/// <param name="min"> Минимальное число для рандома.</param>
/// <param name="max"> Максимальное число для рандома. </param>
/// <returns> Заполненный двумерный массив целых чисел. </returns>
int[,] GetMatrixRndInt(int rows, int cols, int min, int max) 
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
/// <summary>
/// Метод печатает матрицу, которую передали на вход.
/// </summary>
/// <param name="inputMatrix"> Входная матрица. </param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (j < inputMatrix.GetLength(1) - 1) Console.Write($"{inputMatrix[i, j]}\t");
            else Console.Write($"{inputMatrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
/// <summary>
/// Метод сортирует по убыванию элементы каждой строки двумерного массива.
/// </summary>
/// <param name="matrix"> Отсортированный массив. </param>
void SortMaxToMinRows(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear();
int[,] resultMatrix = GetMatrixRndInt(3, 3, -15, 15);
PrintMatrix(resultMatrix);
Console.WriteLine("В итоге получается отсортированный массив:");
SortMaxToMinRows(resultMatrix);
PrintMatrix(resultMatrix);