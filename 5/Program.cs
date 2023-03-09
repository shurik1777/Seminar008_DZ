/*
ДОПОЛНИТЕЛЬНАЯ ЗАДАЧКА
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/// <summary>
/// Проверка на числа
/// </summary>
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
/// <summary>
/// Метод спирального заполнения
/// </summary>
void SpiralArray(int[,] array)
{
    int i = 0, j = 0;
    int value = 1;
    int s = array.GetLength(0);
    for (int n = 0; n < s * s; n++)
    {
        int k = 0;
        do { array[i, j++] = value++; }
        while (++k < s - 1);
        for (k = 0; k < s - 1; k++)
        {
            array[i++, j] = value++;
        }
        for (k = 0; k < s - 1; k++)
        {
            array[i, j--] = value++;
        }
        for (k = 0; k < s - 1; k++)
        {
            array[i--, j] = value++;
        }
        ++i; ++j;
        s = s < 2 ? 0 : s - 2;
    }
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

Console.Clear();
int size = InputNumbers("Введите размерность массива: ");
int[,] resultMatrix = new int[size, size];
SpiralArray(resultMatrix);
PrintMatrix(resultMatrix);