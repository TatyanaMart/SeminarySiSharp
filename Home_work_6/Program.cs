// //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2	
// Console.WriteLine("Введите количество чисел: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine($"Введите {i + 1}-е число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     if (array[i] > 0) count++;
// }
// Console.WriteLine($"Чисел больше нуля: {count}");


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
Console.WriteLine("Введите параметры для функции y = k1 * x + b1: ");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите параметры для функции y = k2 * x + b2: ");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    Console.WriteLine($"Координаты точки пересечения прямых: ({Math.Round(x, 1)}; {Math.Round(y, 1)})");
}
else Console.WriteLine("Прямые параллельны");

