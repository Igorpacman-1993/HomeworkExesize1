/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("x = {x}, z ={z}.");

double [,] array = new double [x, z];

CreateArrayDouble(array);
WriteArray(array);
Console.WriteLine();

void CreateArrayDouble(double [,] array)
{
    for (int i = 0; i <x; i++)
    {
        for (int j = 0; j < z; j++)
        {
            array [i, j] = new Random().NextDouble() * 20 - 10;
        }
    } 
}

void WriteArray (double[,] array)
{
    for (int i = 0; i < x; i++)
 {
      for (int j = 0; j < z; j++)
      {
        double aligNumber = Math.Round(array[i, j], 1);
        Console.Write(aligNumber + " ");
      }
      Console.WriteLine();
 }
}