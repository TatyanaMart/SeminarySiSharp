// //Написать программу, которая на вход принимает число и выводит его квадрат
// Console.WriteLine ("Введите число: ");
// int sqr = number * number;
// Console.WriteLine(sqr);


// // Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// Console.WriteLine ("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2 * number2)
// {
//     Console.WriteLine ("Число 1 является квадратом числа 2");
//  }
//  else 
//  {
//     Console.WriteLine ("Число 1 не является квадратом числа 2");
//  }

// if (numberDay >= 1 && numberDay <= 7 ) знак && говорит о том, что для истины должны быть выполнены оба условия
// if (numberDay < 1 || numberDay > 7 ) знак || говорит о том, что для истины должно быть выполнено хотя бы одно условие


// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// Console.WriteLine ("Введите число: ");
// int numberDay = Convert.ToInt32(Console.ReadLine());
// if (numberDay < 1 || numberDay > 7 )
// {
//     Console.WriteLine ("Ошибка!");
// }
// if (numberDay == 1 )
// {
//     Console.WriteLine ("Понедельник");
// }
// if (numberDay == 2 )
// {
//     Console.WriteLine ("Вторник");
// }
// if (numberDay == 3 )
// {
//     Console.WriteLine ("Среда");
// }
// if (numberDay == 4 )
// {
//     Console.WriteLine ("Четверг");
// }
// if (numberDay == 5 )
// {
//     Console.WriteLine ("Пятница");
// }
// if (numberDay == 6 )
// {
//     Console.WriteLine ("Суббота");
// }
// if (numberDay == 7 )
// {
//     Console.WriteLine ("Воскресенье");
// }


// // Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.Write ("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberNeg = number * (-1);

// while (numberNeg <= number)
// {
//     Console.WriteLine (numberNeg);
//     numberNeg ++;
// }


// Напишите программу, которая на вход принимает трехзначное число, а на выходе показывает последнюю цифру этого числа
Console.WriteLine ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000 )
{
    int number_end = number%10;
    Console.Write("Последняя цифра: "); 
    Console.WriteLine(number_end);  
}
else
{
    Console.WriteLine("Ошибка!"); 
}
