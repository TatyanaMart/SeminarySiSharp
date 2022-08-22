/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7; a = 2 b = 10 -> max = 10; a = -9 b = -3 -> max = -3 */
// Вариант 1
// Console.WriteLine("Введите число 1:  ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:  ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}");
// if (num2 > num1) Console.WriteLine($"Число {num2} больше числа {num1}");
// if (num1 == num2) Console.WriteLine($"Числa равны");

// // Вариант 2
// Console.WriteLine("Введите число 1:  ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:  ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"Число {num1} больше числа {num2}");
// }
// else
// {
//     if (num2 > num1) 
//     {
//         Console.WriteLine($"Число {num2} больше числа {num1}");
//     }
//     else
//     {
//         Console.WriteLine($"Числa равны");
//     }
// }


// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 44 5 78 -> 78
// int num1 = new Random().Next(1, 100);
// Console.WriteLine(num1);

// int num2 = new Random().Next(1, 100);
// Console.WriteLine(num2);

// int num3 = new Random().Next(1, 100);
// Console.WriteLine(num3);

// int max=num1;
// if (num2>max) max=num2;
// if (num3>max) max=num3;
// Console.WriteLine($"Максимальное из 3 чисел {max}");


// /* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да; -3 -> нет; 7 -> нет */
// int num = new Random().Next(1, 100);
// Console.WriteLine(num);
// if (num%2==0) Console.WriteLine ($"Число {num} четное");
// else Console.WriteLine ($"Число {num} нечетное");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:  ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 2;

if (a > 1)
{
    while (b <= a)
    {
        Console.WriteLine(b);
        b += 2;
    }
}
else Console.WriteLine("Четных чисел нет");
