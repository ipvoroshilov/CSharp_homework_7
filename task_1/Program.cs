// ##Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int[,] FillPrintArray(int row, int col)
{
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(-999,1000);
            Console.Write($"{array[i,j]} \t");
        }
        Console.WriteLine();
    }
    return array;
}
try
{
    Console.Write("Введите количество строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] result = FillPrintArray(m, n);
}
catch 
{
        Console.WriteLine("error");
}

// Console.Write("Введите количество строк: \t");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: \t");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i,j] = new Random().Next(-999,1000);
//         Console.Write($"{array[i,j]} \t");
//     }
//     Console.WriteLine();

// }