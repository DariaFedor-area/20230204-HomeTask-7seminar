// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*СЕМИНАР_7:
ЗАДАЧА_47: задайте двумерный массив размером m x n, заполненный случайными вещественными числами.
m=3, n=4

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();
Console.WriteLine("задайте параметры массива:");
Console.Write("высота(количество строк): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ширина(количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());

int minValue = -10;
int maxValue = 10;

double[,] Matrix(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return result;
}
double[,] MultiMatrix = Matrix(m, n, minValue, maxValue);

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Console.Write(array[i, j] + " ");
            Console.Write($"{array[i, j]:f3} ");
        }
        Console.WriteLine();
    }
}
PrintMatrix(MultiMatrix);
