// Задайте двумерный массив целых чисел. Напишите программу, которая
// находит максимальный элемент в каждой строке массива и выводит его.

using System.Globalization;

void Main()
{
    int sizeOfRow = ReadInt("Введите количество строк: ");
    int sizeOfCol = ReadInt("Введите количество колонок: ");
    int[,] matrix = GenerationMatrix(sizeOfRow, sizeOfCol, 2, 87);
    PrintMatrix(matrix);
    MaxElementOfRowInMatrix(matrix);
}
// метод для вывода матрицы
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        // делаем отступ пустой строкой для более презентабельного вывода двумерной матрицы
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

// метод, который найдёт максимально число
void MaxElementOfRowInMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] > max)
            {
                max = matrix[i, j];
            }
        }
        System.Console.WriteLine($"В строке {i} максимальный элемент: {max}");
    }
}

// метод для генерации массива
int[,] GenerationMatrix(int rowSize, int colSize, int minValue = 1, int maxValue = 100)
{
    int[,] tempMatrix = new int[rowSize, colSize];
    Random rnd = new Random();
    for(int i = 0; i < rowSize; i++)
    {
        for(int j = 0; j < colSize; j++)
        {
            tempMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return tempMatrix;
}

// метод для запроса количества строк и колонок от пользователя
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}



Main();