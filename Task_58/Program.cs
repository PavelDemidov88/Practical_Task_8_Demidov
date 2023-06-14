// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixA = GetArray(2, 2, 0, 5);
int[,] matrixB = GetArray(2, 2, 6, 9);
int[,] matrixRes = MatrixMult(matrixA, matrixB);

PrintArray(matrixA);
Console.WriteLine();
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет: ");
Console.WriteLine();
PrintArray(matrixRes);

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
 int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
 {
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if(matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for(int i=0; i<rowsA; i++)
        {
            for(int j=0; j<columnsB; j++)
            {
                for(int k=0; k<matrixA.GetLength(1); k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }
    return result;
 }