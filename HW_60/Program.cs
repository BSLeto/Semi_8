Console.Clear();
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] resultArray = new int[x, y, z];
GetArray(resultArray);
PrintArray(resultArray);

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintArray(int[,,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            Console.Write($" ");
            for (int k = 0; k < resultArray.GetLength(2); k++)
            {
                Console.Write($"X({i}) Y({j}) Z({k})={resultArray[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void GetArray(int[,,] resultArray)
{
    int[] tempArray = new int[resultArray.GetLength(0) * resultArray.GetLength(1) * resultArray.GetLength(2)];
    int number;
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        tempArray[i] = new Random().Next(10, 100);
        number = tempArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10, 100);
                    j = 0;
                    number = tempArray[i];
                }
                number = tempArray[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < resultArray.GetLength(0); x++)
    {
        for (int y = 0; y < resultArray.GetLength(1); y++)
        {
            for (int z = 0; z < resultArray.GetLength(2); z++)
            {
                resultArray[x, y, z] = tempArray[count];
                count++;
            }
        }
    }
}