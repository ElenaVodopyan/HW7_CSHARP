// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(int rowSize, int colSize)
{
    double[,] numbers = new double[rowSize, colSize];
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
            numbers[i, j] = new Random().NextDouble();
    }
    return numbers;
}


void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write(string.Format("{0:f2} ", array[i, j])); 
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Задайте размер массива (m,n):");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] nums2 = FillArray(m, n);
ShowArray(nums2);
