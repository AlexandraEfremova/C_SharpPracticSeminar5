// Задайте двумерный массив. Замените все отрицательные числа на их
// абсолютные значения.

void Main()
{
    int sizeRow = ReadInt("Введите количество строк: ");
    int sizeCol = ReadInt("Введите количество колонок: ");
    int[,] matrix = GenerationMatrix(sizeRow, sizeCol, -50, 50);
    PrintArray(matrix);
    System.Console.WriteLine();
    PositiveArray(matrix);
}
// замена отрицательных на положительные
void PositiveArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 0)
            {
                System.Console.Write($"{matrix[i,j]} \t");
            }
            else
            {
                System.Console.Write($"{matrix[i, j] = matrix[i, j] * (-1)} \t");
            }
        }
        System.Console.WriteLine();
    }
}

// вывод массива в консоль
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

// генерация массива
int[,] GenerationMatrix(int row, int col, int minRange = -10, int maxRange = 20)
{
    int[,] tempMatrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rnd.Next(minRange, maxRange + 1);
        }
    }
    return tempMatrix;
}

// запрос размера массива от пользователя
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


Main();