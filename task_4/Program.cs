// ##Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(-10,10);
            //Console.Write($"{array[i,j]} \t");
        }
    }
    return array;
}
int[] ConvertToSimpleArray(int[,] doubleArray)
{
    int[] simpleArray = new int[doubleArray.GetLength(0)*doubleArray.GetLength(1)];
    int count = 0;
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            simpleArray[count] = doubleArray[i,j];
            //Console.Write($"{simpleArray[count]} \t");
            count++;
        }
    }
    return simpleArray;
}
int[] SortArrayMinToMax(int[] simpleArray)
{
// Первый вариант через while
    //int size = simpleArray.Length; // Первый вариант через while
    // while (size > 0)
    // {
    //     int maxInd = 0;
    //     for (int i = 0; i < size; i++)
    //     {
    //         if (simpleArray[i] > simpleArray[maxInd]) 
    //         {
    //             maxInd = i;
    //         }
    //     }
    //     int temp = simpleArray[size -1];
    //     simpleArray[size - 1] = simpleArray[maxInd];
    //     simpleArray[maxInd] = temp;
    //     size = size - 1;
    // }
    
// Второй вариант через for
    int size = simpleArray.Length; 
    for (size = simpleArray.Length; size > 0; size--)
    {
        int maxInd = 0;
        for (int i = 0; i < size; i++)
        {
            if (simpleArray[i] > simpleArray[maxInd]) 
            {
                maxInd = i;
            }
        }
        int temp = simpleArray[size -1];
        simpleArray[size - 1] = simpleArray[maxInd];
        simpleArray[maxInd] = temp;
    }
// Третий вариант через for
    //int minInd = 0; 
    //int temp = 0;
    
    // for (int minInd = 0; minInd < simpleArray.Length; minInd++)
    // {
    //     for (int i = 0; i < simpleArray.Length; i++)
    //     {
    //         if (simpleArray[i] > simpleArray[minInd])
    //         {
    //             temp = simpleArray[minInd];
    //             simpleArray[minInd] = simpleArray[i];
    //             simpleArray[i] = temp;
    //         }
    //     }

    // }

    return simpleArray;
}

void PrintSimpleArray(int[]simpleArray)
{
    for (int i = 0; i < simpleArray.Length; i++)
    {
        Console.Write($"{simpleArray[i]} \t");
    }
        Console.WriteLine();
}
int[,] ConvertToDoubleArray(int[] simpleArray, int row, int col)
{
    int[,] doubleArray = new int[row,col];
    int count = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            doubleArray[i,j] = simpleArray[count];
            count++;
        }
    }
    return doubleArray;
}
void PrintDoubleArray(int[,]array)
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

try
{
    Console.Write("Введите количество строк: \t");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: \t");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вот сгенерированный массив:");
    int[,] initialDoubleArray = FillArray(m, n);
    PrintDoubleArray(initialDoubleArray);
    Console.WriteLine("Вот мы его сконвертировали в одномерный массив:");
    int[] convertedSimpleArray = ConvertToSimpleArray(initialDoubleArray);
    PrintSimpleArray(convertedSimpleArray);
    Console.WriteLine("Вот мы его отсортировали:");
    int[] sortedSimpleArray = SortArrayMinToMax(convertedSimpleArray);
    PrintSimpleArray(sortedSimpleArray);
    Console.WriteLine("Вот мы сконвертировали его в двумерный массив:");
    int[,] sortedDoubleArray = ConvertToDoubleArray(sortedSimpleArray, m, n);
    PrintDoubleArray(sortedDoubleArray);
}
catch 
{
        Console.WriteLine("error");
}