/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {(SumNumbers(m, n))}");

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        if (m < n)
        {
            return m + SumNumbers(m + 1, n);
        }
        else
        {
            return m + SumNumbers(m - 1, n);
        }
    }
}