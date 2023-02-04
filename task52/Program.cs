// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*СЕМИНАР_7:
ЗАДАЧА_52: задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
например, задан массив
1 4 7 2 
5 9 2 3
8 4 2 4
среднее арифметическое каждого столбца
4,6 5,6 3,6 3
*/
Console.Clear();
Console.Write("высота(количество строк):");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ширина(количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());

int minValue = 0;
int maxValue = 100;

int[,] MultiArray(int m, int n, int minValue, int maxValue) // min и max можно задать вручную здесь, или запросить у пользов.
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return (result);
}

int[,] Matrix = MultiArray(m, n, minValue, maxValue);

void PrintMultyArray(int[,] mArray)
{
    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        for (int j = 0; j < mArray.GetLength(1); j++)
        {
            Console.Write($"{mArray[i, j]} ");

        }
        Console.WriteLine();
    }
}

void AverageColumn(int[,] mArray)
{
    Console.WriteLine();
    for (int j = 0; j < mArray.GetLength(0); j++)
    {
        float sum = 0;
        for (int i = 0; i < mArray.GetLength(1); i++)
        {
            sum += mArray[i, j];
        }
        Console.Write($"{(sum / n):f2} | ");
    }
}
PrintMultyArray(Matrix);
AverageColumn(Matrix);