// //Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
// int num = new Random().Next(10, 100);
// int num1 = num / 10;
// int num2 = num % 10;

// Console.WriteLine(num);

// if (num1 > num2)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     Console.WriteLine(num2);
// }


// //Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// int num = new Random().Next(10, 100);
// Console.WriteLine(num);

// int num1 = num / 100;
// int num2 = num % 10;

// Console.WriteLine(num1 * 10 + num3);

// // Еще вариант:
// int num = new Random().Next(10, 100);
// int num1 = num / 100;
// int num2 = num % 10;
// Console.WriteLine(num);
// Console.Write(num1);
// Console.Write(num2);


// //Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4  16, 4 -> кратно
// // Без указания остатка (не полностью решили):
// int num1 = new Random().Next(10, 100);
// int num2 = new Random().Next(10, 100);

// Console.WriteLine(num1);
// Console.WriteLine(num2);

// if (num1 % num2 == 0)
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine("не кратно");
// }

// // Готовый вариант (чужой):
// Console.WriteLine("Введите число 1: "); int number1 = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Введите число 2: "); int number2 = Convert.ToInt32(Console.ReadLine()); int result = number2 % number1; if (result == 0) { Console.WriteLine("Число кратно."); } else { Console.WriteLine("Остаток от деления: " + result); }


// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет  46 -> нет  161 -> да

// int number1 = new Random().Next(10, 100);

// int number1 = 161;
// Console.WriteLine(number1);

// if (number1 % 7 == 0 && number1 % 23 == 0)
// {
//     Console.WriteLine("Число кратно.");
// }
// else
// {
//     Console.WriteLine("Число не кратно.");
// }


// // Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
int number1 = new Random().Next(10, 100);
Console.WriteLine(number1);

int number2 = new Random().Next(10, 100);
Console.WriteLine(number2);

if (number1 * number1 == number2 || number2 * number2 == number1)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}

// // Еще вариант:
// Console.WriteLine("Введите число 1:  ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2:  ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }
// else if (number2 == number1 * number1)
// {
//     Console.WriteLine("Число 2 является квадратом числа 1");
// }
// else
// {
//     Console.WriteLine("Числа не являются квадратами друг друга");

//     string a = "Урок";
//     string b = "Один";
//     Console.WriteLine(a + " " + b); // Канкатинация
//     Console.WriteLine(a + " " + b);
//     Console.WriteLine($"Число {a} является квадратом {b}"); //Интерполяция

