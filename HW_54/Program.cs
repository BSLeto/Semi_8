Console.Clear();
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void PhoneticArray(int[,] inputMatrix)
{
    int max = inputMatrix[0, 0];
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(1); k++){
                if (inputMatrix[i,j]<= inputMatrix[i,k]){
                    int temp = inputMatrix[i,j];
                    inputMatrix[i,j] = inputMatrix[i,k];
                    inputMatrix[i,k] = temp;
                }
            }
        }
    }
}
Console.WriteLine("result: ");
PhoneticArray(resultMatrix);
PrintArray(resultMatrix);