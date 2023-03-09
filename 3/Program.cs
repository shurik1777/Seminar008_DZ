/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/// <summary>
/// Этот метод заполняет двумерный массив,
/// числами от min до max.
/// </summary>
/// <param name="rows"> Количество строк. </param>
/// <param name="cols"> Количество столбцов. </param>
/// <param name="min"> Минимальное число для рандома. </param>
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
            else Console.Write($"{inputMatrix[i, j]}");
        }
        Console.WriteLine();
    }
}
/// <summary>
/// Метод перемножающий 2 матрицы.
/// </summary>
/// <param name="arrayFirst"> Первая матрица. </param>
/// <param name="arraySecond"> Вторая матрица. </param>
/// <returns> Результат. </returns>
int[,] MultiplyArrays(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] array = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                array[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
    return array;
}

Console.Clear();
int[,] firstInMatrix = GetMatrixRndInt(2, 2, 2, 4);
int[,] secondInMatrix = GetMatrixRndInt(2, 2, 2, 4);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstInMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondInMatrix);
Console.WriteLine();
/// <summary>
/// Проверка кол-ва столбцов 1й матрицы и строк 2й для умножения
/// </summary>
if (firstInMatrix.GetLength(1) == secondInMatrix.GetLength(0))
{
    int[,] resultMatrix = MultiplyArrays(firstInMatrix, secondInMatrix);
    Console.WriteLine("Произведение двух матриц:");
    PrintMatrix(resultMatrix);
}
else Console.WriteLine("Данные матрицы перемножать нельзя!");