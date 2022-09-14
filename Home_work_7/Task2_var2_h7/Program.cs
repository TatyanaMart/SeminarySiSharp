/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

// Вариант решения с помощью методов
int[,] matrix = new int[3, 4];

FillPrintArray(matrix);

Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

GetElement(matrix, row, column);

void FillPrintArray(int[,] matr) // метод заполняет матрицу случайными числами и печатает ее
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

void GetElement(int[,] matr, int row, int column) // метод поиска значения элемента с указанной позицией
{
    if (row < matr.GetLength(0) && column < matr.GetLength(1))
    {
        Console.WriteLine($"Значение указанного элемента: {matr[row, column]}");
    }
    else
    {
        Console.WriteLine("Элемент с указанными индексами не найден");
    }
}




