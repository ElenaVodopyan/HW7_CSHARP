//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine("Введите позицию элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] nums2 = FillArray(3, 4);
ShowArray(nums2);

if (m <= 3 && n <= 4)
{
    Console.WriteLine(string.Format("{0:f2} ", nums2[m - 1, n - 1]));
}
else
{
    Console.WriteLine($"{m} {n} -> такого элемента в массиве нет");
}