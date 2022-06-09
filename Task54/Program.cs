/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

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

void OrderingMatrixRows(int[,] matrix)                                  // Метод упорядочивания по убыванию элементов в строках матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1) - j - 1; n++)
            {
                if (matrix[i, n] < matrix[i, n + 1])
                {
                    int temp = matrix[i, n];
                    matrix[i, n] = matrix[i, n + 1];
                    matrix[i, n + 1] = temp;
                }
            }
        }
    }
}

int firstDemension = GetDemension("Введите число строк матрицы:");
int secondDemension = GetDemension("Введите число столбцов матрицы:");
int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);
OrderingMatrixRows(resultMatrix);
PrintMatrix(resultMatrix);
