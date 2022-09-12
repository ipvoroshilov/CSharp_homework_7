// ##Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] RandomFillArray()
{
    int row = new Random().Next(2,10);
    int col = new Random().Next(2,10);
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(1,1000);
        }
    }
    return array;
}

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
}

void ColumnAverage(int[,] array)
{
    double sum = 0;
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        average = Math.Round((sum/array.GetLength(0)),2);
        Console.Write($"{average} \t");
        sum = 0;
        average = 0;
    }    
}
try
{
    Console.WriteLine("Сгенерированный массив:");
    int[,] table = RandomFillArray();
    PrintArray(table);
    Console.WriteLine("Среднее арифмитическое по колонкам:");
    ColumnAverage(table);
}
catch 
{
    Console.WriteLine("error");
}