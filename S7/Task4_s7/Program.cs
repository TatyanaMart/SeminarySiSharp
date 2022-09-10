//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int sum = 0;
double[,] array = new double[rows, columns];
Console.WriteLine("Массив:");

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

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (i == j)
        {
            sum += Convert.ToInt32(array[i, j]);
        }
    }
}
Console.WriteLine("Cумма элементов:" + sum);


//Чужой вариант
Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
int sum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        if (i == j)
        {
            sum += matrix[i, j];
        }
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine($"Сумма = {sum}");
