/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

FillPrintArray(array);
GetAverage(array);

void FillPrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 11);
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void GetAverage(int[,] matr)
{
    for (int i = 0; i < columns; i++)
    {
        double sum = 0.0;
        for (int j = 0; j < rows; j++)
        {
            sum += matr[j, i];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {sum / rows}");
    }
}
