/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

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

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)            // Метод умножения двух матриц
{
    int[,] ComposureMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < ComposureMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ComposureMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            ComposureMatrix[i, j] = sum;
        }
        Console.WriteLine();
    }
    for (int m = 0; m < ComposureMatrix.GetLength(0); m++)               // Вывод результата на печать
    {
        for (int n = 0; n < ComposureMatrix.GetLength(1); n++)
        {
            Console.Write($"{ComposureMatrix[m, n]}" + "    ");
        }
        Console.WriteLine();
    }
}


int firstDemension = GetDemension("Введите число строк матрицы 1:");
int secondDemension = GetDemension("Введите число столбцов матрицы 1:");
int[,] resultMatrix1 = InitMatrix(firstDemension, secondDemension);
PrintMatrix(resultMatrix1);
int thirdDemension = GetDemension("Введите число строк матрицы 2 (должно совпадать с числом столбцов матрицы 1):");
int fouthDemension = GetDemension("Введите число столбцов матрицы 2 (должно совпадать с числом строк матрицы 1):");
int[,] resultMatrix2 = InitMatrix(thirdDemension, fouthDemension);
PrintMatrix(resultMatrix2);
MultiplyMatrix(resultMatrix1, resultMatrix2);



