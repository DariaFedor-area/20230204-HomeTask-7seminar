// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


/*СЕМИНАР_7:
ЗАДАЧА_50: напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указане, что такого элемента нет.
напрмер, задан массив
1 4 7 2 
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.Clear();
Console.WriteLine("задайте параметры массива:");
Console.Write("высота(количество строк):");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ширина(количество столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("проверим есть ли ваша число в нем ваше число:");
int x = Convert.ToInt32(Console.ReadLine());

int minValue = 0;
int maxValue = 10;

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

void FindNumber(int[,] mArray)
{
    Console.WriteLine();
    for (int i = 0; i < mArray.GetLength(0); i++)
    {
        for (int j = 0; j < mArray.GetLength(1); j++)
        {
            if (mArray[i, j] == x)
            {
                Console.WriteLine("ваше число есть в массиве");
                break;
            }
            else
            {
                break;
                Console.WriteLine("ваше число не присутствует в массиве");
            }
        }
    }
}

PrintMultyArray(Matrix);
FindNumber(Matrix);