// // Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)
// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("a в степени b = " + GetExponentiation(a, b));

// int GetExponentiation(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11	82 -> 10	9012 -> 12
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма цифр в числе = " + GetSum(num));

// int GetSum(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }


// /* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
//  */
// int[] MyArray = new int[8];

// int[] GetRandomArray(int[] arr)
// {
//     Console.Write("[");
//     Random rand = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rand.Next(1, 20);
//         Console.Write($"{arr[i]} ");
//     }
//     Console.Write("]");
//     return arr;
// }
// GetRandomArray(MyArray);
// Console.WriteLine();

