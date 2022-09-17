/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:		Результирующая матрица будет:
2 4 | 3 4				        18 20
3 2 | 3 3				        15 18 */
Console.Write("Введите число строк для матрицы А: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов для матрицы А и число строк для матрицы В: ");
int columnsArowsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[rowsA, columnsArowsB];

Console.Write("Введите число столбцов для матрицы В: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = new int[columnsArowsB, columnsB];

Console.WriteLine("Матрица А: ");
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine("Матрица В: ");
FillArray(matrixB);
PrintArray(matrixB);

Console.WriteLine("Произведение матриц А и В: ");
int[,] matrixC = new int[rowsA, columnsB];
GetMatrixProduct(matrixA, matrixB, matrixC);
PrintArray(matrixC);


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 6);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void GetMatrixProduct(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    for (int i = 0; i < rowsA; i++)
    {

        for (int j = 0; j < columnsB; j++)
        {
            int numberC = 0;
            for (int k = 0; k < columnsArowsB; k++)
            {
                numberC += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = numberC;
        }
    }
}