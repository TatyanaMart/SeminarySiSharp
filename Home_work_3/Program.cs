/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет, 12821 -> да, 23432 -> да */
Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
    int temp = num;
    int num1 = 0;
    int num2 = 0;

if (num >= 10000 && num < 100000)
{

    while (num > 0)
    {
        num1 = num % 10;
        num2 = num2 * 10 + num1;
        num = num / 10;
    }

    if (temp == num2)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Ошибка! Это не пятизначное число.");
}


// /* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84, A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Координаты точки А:");

Console.WriteLine("Введите х:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Координаты точки В:");

Console.WriteLine("Введите х:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z:");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2)) + Math.Sqrt(Math.Pow(y2 - y1, 2)) + Math.Sqrt(Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками А и В: {d}");


/* Задача 23/ Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= n)
{
    Console.Write(Math.Pow(count, 3) + " ");
    count++;
}
Console.WriteLine();


