// Задайте двумерный массив целых чисел. Напишите программу, которая
// транспонирует массив (меняет строки и столбцы местами).
void Main()
{
    int sizeRow = PrintInt("Введите количество строк: ");
    int sizeCol = PrintInt("Введите количество столбцов: ");
    int[,] matrix = GeneraiteMatrix(sizeRow, sizeCol, 1, 50);
    PrintMatrix(matrix);
    int[,] transposMatrix = TranspositionMatrix(matrix, sizeRow, sizeCol);
    PrintMatrix(transposMatrix);
}
// Метод на транспонирование массива
int[,] TranspositionMatrix(int[,] matrix, int row, int col)
{
    int[,] tempMatrix = new int[col, row];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            tempMatrix[j,i] = matrix[i,j];
        }
    }
    return tempMatrix;
}

// Вывод массива
void PrintMatrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// генерация массива
int[,] GeneraiteMatrix(int row, int col, int minRange, int maxRange)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(minRange, maxRange + 1);
        }
    }
    return matrix;
}
// вывод сообщения для пользователя и ввод пользователем данных
int PrintInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();