/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2:
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Write("Введите длину: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[a, b, c];
int[] numbers = new int[90]; // массив двузначных чисел

if (a * b * c < 90)
{
    FillArrayTwoDigitNumbersInOrder(numbers);
    FillArrayTwoDigitNumbersRandom(matrix, numbers);
    PrintArray(matrix);
}
else
{
    Console.WriteLine("Произведение параметров превышает 90. Неповторяющихся двузначных чисел недостаточно для заполнения массива.");
}

void FillArrayTwoDigitNumbersInOrder(int[] matrix) //заполнение массива двузначными числами по порядку
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        matrix[i] = 10 + i;
    }
}

void FillArrayTwoDigitNumbersRandom(int[,,] matrix1, int[] matrix2) //заполнение массива двузначными числами не по порядку
{
    int count = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(2); k++)
            {
                int number = new Random().Next(0, 90); //случайный номер элемента массива двузначных чисел
                while (matrix2[number] == 0)
                {
                    number = count;
                    count++;
                }
                matrix1[i, j, k] = matrix2[number];
                matrix2[number] = 0;
                count = 0;
            }
        }
    }
}


void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k] + " " + (i, j, k) + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
