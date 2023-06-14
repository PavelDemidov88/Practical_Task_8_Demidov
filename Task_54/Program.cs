// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");

int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 5);
PrintArray(array);
Console.WriteLine("Массив упорядоченный по убыванию: ");
GetSortArray(array);
PrintArray(array);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows,columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0;j<columns; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void GetSortArray(int[,] arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            for(int k=0; k<arr.GetLength(1)-1; k++)
            {
                if(arr[i, k] < arr[i, k+1])
                {
                    int temp = arr[i, k+1];
                    arr[i, k+1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}