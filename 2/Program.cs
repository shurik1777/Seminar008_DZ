/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/// <summary>
/// Этот метод заполняет двумерный массив
/// числами от min до max
/// </summary>
/// <param name="rows">Количество строк</param>
/// <param name="cols">Количество столбцов</param>
/// <param name="min">Минимальное число для рандома</param>
/// <param name="max">Максимальное число для рандома</param>
/// <returns>Заполненный двумерный массив целых чисел</returns>
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
/// Метод печатает матрицу, которую передали на вход
/// </summary>
/// <param name="inputMatrix"> Двумерный массив или таблица </param>
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // Строчки
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++) // Столбцы
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/// <summary>
/// Метод вычисляет сумму элементов в каждой строке
/// </summary>
/// <param name="matrix">Двумерный массив</param>
/// <returns>Одномерный массив, заполненный этими суммами</returns>
int[] CountSumForEachRow(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArray[i] += matrix[i, j];
        }
    }
    return sumArray;
}
/// <summary>
/// Метод печатает одномернный массив, которую передали на вход
/// </summary>
/// <param name="array">Одномерный массив</param>
void PrintArray(int[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine(")");
}
/// <summary>
/// Метод принимает на вход одномерный массив
/// </summary>
/// <param name="array">Одномерный массив</param>
/// <returns>Находит наименьшее число среди значений элементов</returns>
int FindLessNumber(int[] array)
{
    int min = array[0];
    int numberRow = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            numberRow = i;
        }
    }
    return numberRow;
}

Console.Clear();
int[,] array2D = GetMatrixRndInt(6, 6, 0, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] sumArr = CountSumForEachRow(array2D);
PrintArray(sumArr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindLessNumber(sumArr)+1} строка");