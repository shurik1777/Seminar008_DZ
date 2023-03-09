/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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
/// Вывод на печать суммы куба и индексов
/// </summary>
/// <param name="arrayCube"></param>
void PrintArrayCube(int[,,] arrayCube)
{
    for (int i = 0; i < arrayCube.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCube.GetLength(1); j++)
        {
            for (int k = 0; k < arrayCube.GetLength(2); k++)
            {
                Console.Write($"{arrayCube[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}
/// <summary>
/// Создание 3х мерного массива с рандомом.
/// /// </summary>
/// <param name="arrayCube"> Входная матрица. </param>
void CreateArrayCube(int[,,] arrayCube)
{
  int[] temp = new int[arrayCube.GetLength(0) * arrayCube.GetLength(1) * arrayCube.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arrayCube.GetLength(0); x++)
  {
    for (int y = 0; y < arrayCube.GetLength(1); y++)
    {
      for (int z = 0; z < arrayCube.GetLength(2); z++)
      {
        arrayCube[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.Clear();
Console.WriteLine($"Введите размер массива X\tY\tZ: ");
int rowsCube = InputNumbers("Введите X: ");
int columnsCube = InputNumbers("Введите Y: ");
int depthCube = InputNumbers("Введите Z: ");
Console.WriteLine("Трёхмерный массив: ");
int[,,] arrayCube = new int[rowsCube, columnsCube, depthCube];
CreateArrayCube(arrayCube);
PrintArrayCube(arrayCube);
