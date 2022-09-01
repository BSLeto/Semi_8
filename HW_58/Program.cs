Console.Clear();

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Write($"Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n) //m - строчки n - столбцы
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}


void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Первая матрица");
int[,] firstMatrix = GetArray(rows, columns);
PrintArray(firstMatrix);
Console.WriteLine("Вторая матрица");
int[,] secondMatrix = GetArray(rows, columns);
PrintArray(secondMatrix);

int[,] MultiMatrix(int[,] FirstMatrixInput, int[,] SecondMatrixInput)
{
    int [,] matrix = new int[FirstMatrixInput.GetLength(0), SecondMatrixInput.GetLength(1)];
    for (int i = 0; i < FirstMatrixInput.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrixInput.GetLength(1); j++)
        {  
            matrix[i, j] = FirstMatrixInput[i, j] * SecondMatrixInput[i, j];
        }
    }
    return matrix;
}
int [,] resultMatrix = MultiMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Результат: ");
PrintArray(resultMatrix);