// /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве. [345, 897, 568, 234] -> 2 */
// int[] GetArray(int[] arr) // Задает и выводит массив заполненный случайными положительными трёхзначными числами.
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(100, 1000);
//         Console.Write($" {arr[i]} ");
//     }
//     Console.Write("]\n");
//     return arr;
// }

// int[] GetAmountEven(int[] arr) // Показывает количество чётных чисел в массиве.
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine("Количество чётных чисел в массиве:" + count);
//     return arr;
// }

// int[] MyArray = new int[6];
// GetArray(MyArray);
// GetAmountEven(MyArray);



// /* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. 
// [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0 */
// int[] GetArray(int[] arr) // Задает и выводит массив заполненный случайными числами.
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(-20, 20);
//         Console.Write($" {arr[i]} ");
//     }
//     Console.Write("]\n");
//     return arr;
// }
// int[] GetSumOdd(int[] arr) // Выводит сумму значений нечетных элементов в массиве.
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             count += arr[i];
//         }
//     }
//     Console.WriteLine($"Сумма значений нечётных элементов в массиве = " + count);
//     return arr;
// }

// int[] MyArray = new int[4];
// GetArray(MyArray);
// GetSumOdd(MyArray);


// //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. [3 7 22 2 78] -> 76

// // Вариант 1. Выводится массив вещественных чисел от 0 до 1 с помощью Random().NextDouble().
// double[] GetArray(double[] arr) // Задает и выводит массив заполненный случайными вещественными числами.
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().NextDouble();
//         Console.Write($" {(arr[i])} ");
//     }

//     Console.Write("]\n");
//     return arr;
// }

// void GetDifference(double[] arr)
// {
//     double max = arr[0];
//     double min = arr[0];
//     double diff = 0;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//         else
//         {
//             if (arr[i] < min)
//             {
//                 min = arr[i];
//             }
//         }
//     }
//     diff = max - min;
//     Console.Write($"Разница между максимальным {max} и минимальным {min} элементами = {diff}\n");

// }

// double[] MyArray = new double[5];
// GetArray(MyArray);
// GetDifference(MyArray);

// // Вариант 2. Выводится массив вещественных чисел с помощью Random().Next().
// double[] GetArray(double[] arr) // Задает и выводит массив заполненный случайными вещественными числами.
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0,100);
//         Console.Write($" {(arr[i])} ");
//     }

//     Console.Write("]\n");
//     return arr;
// }

// void GetDifference(double[] arr)
// {
//     double max = arr[0];
//     double min = arr[0];
//     double diff = 0;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//         else
//         {
//             if (arr[i] < min)
//             {
//                 min = arr[i];
//             }
//         }
//     }
//     diff = max - min;
//     Console.Write($"Разница между максимальным {max} и минимальным {min} элементами = {diff}\n");

// }

// double[] MyArray = new double[5];
// GetArray(MyArray);
// GetDifference(MyArray);