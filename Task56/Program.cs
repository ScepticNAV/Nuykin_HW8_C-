/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

int GetDemension(string message)                                        // Метод получения размерности матрицы
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

int[,] InitMatrix(int firstDemension, int secondDemension)              // Метод получения матрицы случайных целых чисел от 0 до 10
{
    int[,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.Next(0, 11);
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)                                         // Метод вывода матрицы на печать
{
    Console.WriteLine("Матрица:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}    ");

        Console.WriteLine();
    }
}

int MatrixMinSumRows(int[,] matrix)                                    // Метод нахождения строки с наименьшей суммой элементов
{
    int sum = 0;
    int minSum = 0;
    int minNumber = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += matrix[i, j];
                minSum += matrix[i, j]; 
            }
            else sum += matrix[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNumber = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Минимальная сумма элементов в строках равна: {minSum}");
    return minNumber;
}

int firstDemension = GetDemension("Введите число строк матрицы:");
int secondDemension = GetDemension("Введите число столбцов матрицы:");
int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);
Console.WriteLine("Номер строки с наименьшей суммой элементов (отсчет от нулевой строки):"  + MatrixMinSumRows(resultMatrix));