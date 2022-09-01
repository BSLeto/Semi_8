Console.Clear();
//Двумерный массив, который меняет местами первую и последнюю строку массива.

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
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);

// Метод замены строк
void ChangeRows(int[,] inputMatrix)
{
    int indexLastRow = inputMatrix.GetLength(0) - 1;
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
        int temp = inputMatrix[0, j];
        inputMatrix[0, j] = inputMatrix[indexLastRow, j];
        inputMatrix[indexLastRow, j] = temp;
    }
}
// ChangeRows(resultMatrix);
// Console.WriteLine("Result:");
// PrintArray(resultMatrix);

//================================================================================================
// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Метод замены строк

int[,] ChangeArray(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
}

// if (rows != columns)
// {
//     Console.WriteLine("Заменить элементы нельзя");
//     return;
// }
// Console.WriteLine("Result: ");
// PrintArray(ChangeArray(resultMatrix));

// *59 задачка: *

Console.WriteLine();

int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int indexMinRows = 0; // строчка
int indexMinColumns = 0; // столбец с мин элементом

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t");
        if (minElement > matrix[i, j]) // 5 > 0, min = 0
        {
            indexMinColumns = j;
            indexMinRows = i;
            minElement = matrix[i, j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Result: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (indexMinRows != i)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (indexMinColumns != j)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
}