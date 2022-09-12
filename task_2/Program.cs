// ##Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] RandomFillArray()
{
    int row = new Random().Next(2,10);
    int col = new Random().Next(2,10);
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(-999,1000);
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

void FindInArray(string number, int[,] array)
{
    int[] numberArray = new int[number.Length];
    for (int i=0; i < number.Length; i++)
    {
        numberArray[i] = int.Parse(number[i].ToString());
    }
    if (numberArray[0] < array.GetLength(0) && numberArray[1] < array.GetLength(1))
    {
        Console.Write("Найденный элемент: \t");
        Console.Write($"{array[numberArray[0],numberArray[1]]} \t");
    }
    else Console.WriteLine("Такого числа в массиве нет.");
}
try
{
    Console.WriteLine("Сгенерированный массив для поиска:");
    int[,] table = RandomFillArray();
    PrintArray(table);
    Console.Write("Введите позицию элемента в двумерном массиве: \t");
    string adress = Console.ReadLine();
    FindInArray(adress, table);
}
catch 
{
        Console.WriteLine("error");
}