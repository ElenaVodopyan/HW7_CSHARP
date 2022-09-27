// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] FillArray(int rowSize, int colSize)
{
    int[,] numbers = new int[rowSize, colSize];
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
            numbers[i, j] = new Random().Next(0,10);
    }
    return numbers;
}
void ShowAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        { 
            summ += array[i, j]; 
        }
        Console.Write(string.Format("{0:f2} ", summ/array.GetLength(0))); 
    }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write(string.Format("{0} ", array[i, j])); 
        }
        Console.WriteLine();
    }
}

int[,] nums2 = FillArray(3, 4);
ShowArray(nums2);
ShowAverage(nums2);