// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[rows, columns];
Console.WriteLine("Первоначальный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Измененный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] = Math.Pow(array[i, j], 2);
        }
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}


//Чужой вариант
int rows = int.Parse(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            matrix[i, j] = Math.Pow(matrix[i, j], 2);
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
