// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 456 -> 5

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99 & number < 1000)
// {
//     int number1 = number / 10;
//     int number2 = number1 % 10;
//     Console.WriteLine("Вторая цифра: " + number2);
// }
// else
// {
//     Console.WriteLine("Ошибка!");
// }


// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 645 -> 5, 
// // 78 -> третьей цифры нет, 32679 -> 6
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num < 1000)
// {
//     int num1 = num % 10;
//     Console.WriteLine(num1);
// }
// else
// {
//     if (num > 999 && num < 10000)
//     {
//         int num2 = (num / 10) % 10;
//         Console.WriteLine(num2);
//     }
//     else
//     {
//         if (num > 9999 && num < 100000)
//         {
//             int num3 = (num / 100) % 10;
//             Console.WriteLine(num3);
//         }
//         else
//         {
//             Console.WriteLine("Третьей цифры нет");
//         }
//     }
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да, 1 -> нет
// Console.WriteLine("Введите номер дня недели от 1 до 7: ");
// int numberDay = Convert.ToInt32(Console.ReadLine());
// if (numberDay >= 1 && numberDay <= 5)
// {
//     Console.WriteLine("Нет, рабочий день");
// }
// else
// {
//     if (numberDay == 6 || numberDay == 7)
//     {
//         Console.WriteLine("Да, выходной день");
//     }
//     else
//     {
//         Console.WriteLine("Ошибка! Дня недели с указанным номером не существует");
//     }
// }