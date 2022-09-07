// /* Задача 39. Напишите программу, которая перевернет одномерный массив (последнийэлемент будет на первом месте, 
// а первый – на последнем и т.д.). [1 2 3 4 5] -> [5 4 3 2 1] */
// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(",", array));

// ReversArray(array);
// Console.WriteLine(String.Join(",", array));

// int[] GetArray(int size, int minValue, int maxValue) // метод, который создает (возвращает) массив, передаем в него размер, мин и макс числа, числа будем брать случайные с пом рандом
// {
//     int[] res = new int[size]; // создаем массив
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1); //присваиваем случайные значения элементам массива. maxValue + 1 - Еси хотим, чтобы макс число в массиве было 5, значит в Random().Next пишем 6
//     }
//     return res;
// }

// void ReversArray(int[] inArray) // метод, который будет менять местами массив
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i]; //передаем в k элемент массива
//         inArray[i] = inArray[inArray.Length - 1 - i]; // передаем на место элемента массива последний элемент массива
//         inArray[inArray.Length - 1 - i] = k;
//     }
// }


// /* Задача 40. Напишите программа, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник с сторонами такой длины. 
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */
// // мой вариант:
// Console.WriteLine("Введите сторону треугольника А: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону треугольника В: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону треугольника С: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num1 + num2 > num3
// && num2 + num3 > num1
// && num1 + num3 > num2)
// {
//     Console.WriteLine("Треугольник с заданными сторонами существует.");
// }
// else Console.WriteLine("Треугольник с заданными сторонами не существует.");

// // чужой вариант:
// bool GetNumber(int num1, int num2, int num3)
// {
//     if (num1 > num2 + num3)
//         return false;
//     else if (num2 > num1 + num3)
//         return false;
//     else if (num3 > num1 + num2)
//         return false;
//     else return true;
// }

// bool Triangle = GetNumber(10, 4, 5);
// if (Triangle == true)
// {
//     Console.WriteLine("Треугольник может существовать.");
// }
// else
// {
//     Console.WriteLine("Треугольник не может существовать.");
// }

// //чужой вариант 2
// Console.WriteLine("Введите стороны треугольника(a,b,c): ");
// double number1 = Convert.ToDouble(Console.ReadLine());
// double number2 = Convert.ToDouble(Console.ReadLine());
// double number3 = Convert.ToDouble(Console.ReadLine());

// void CheckTriangle(double a,double b,double c)
// {
//     if( a < b + c && b < c + a && c < a + b)
//     {
//         Console.WriteLine("треугольник со сторонами такой длины может существовать.");
//     }
//     else
//     {
//         Console.WriteLine("такой треугольник не существует");
//     }
// }
// CheckTriangle(number1,number2,number3);


// // Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101  3  -> 11
// // чужой вариант 1 с помощью встроенной функции:
// int value = 6;
// string binary = Convert.ToString(value, 2);

// Console.WriteLine(binary);

// чужой вариант 2:

// void ConvertNum(int number)
// {
//     string resalt = "";
//     while (number > 0) //число само конвертируется в стринг
//     {
//         resalt = number % 2 + resalt;
//         number /= 2;

//     }
//     Console.WriteLine(resalt);

// }
// int intput = Convert.ToInt32(Console.ReadLine());
// ConvertNum(intput);


// /* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8 */
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Fi
// int firstNum = 0;
// int secondNum = 1;
// Console.Write(firstNum + " ");
// Console.Write(secondNum + " ");

// for (int i = 3; i <=num; i++)
// {
//     int newNum = firstNum + secondNum;
//     Console.Write(newNum + " ");
//     firstNum = secondNum;
//     secondNum = newNum;
// }

// //еще чужой вариант
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[number];
// array[0] = 0;
// array[1] = 1;
// for (int i = 2; i < number - 1; i++)
// {
//     array[i + 1] = array[i] + array[i - 1];
//     Console.Write(array[i + 1] + " ");
// }

// // еще вариант препода
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int firstN = 0;
// int secondN = 1;
// Console.Write(firstN + ", ");
// Console.Write(secondN);

// for (int i = 3; i <= num; i++)
// {
//     int newN = firstN + secondN;
//     Console.Write(", " + newN);
//     firstN = secondN;
//     secondN = newN;
// }