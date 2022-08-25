//Задача вывода 3 цифры введенного числа. Вариант решения:
string str = Console.ReadLine();
if (str.Length <= 2)
{
    Console.WriteLine("Введите трехзначное число!");
}
Console.WriteLine(str[2]);

int a = 4356;
Console.WriteLine(а == 1); //проверяет, правда или ложь, Ответ: ошибка программы
Console.WriteLine(a == 4356); //проверяет, правда или ложь? ответ: правда

int a = 4356;
bool b = a == 4356; //проверяет правда или ложь 
Console.WriteLine(b); //Ответ: правда, т.к. 4356=4356

/* Задача: Напишите программу, которая принимает 
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
 и выдаёт номер четверти плоскости, в которой находится
  эта точка. */
Console.WriteLine("Введите Х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (x > 0 && y > 0)
{
    Console.WriteLine("Четверть 1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Четверть 2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Четверть 3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Четверть 1");
}
if (x == 0 && y == 0)
{
    Console.WriteLine("Определить нельзя");
}

// Задача самостоятельная: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти:");
int chetvert = Convert.ToInt32(Console.ReadLine());
if (chetvert == 1)
{
    Console.WriteLine("Х>0, Y>0");

}
if (chetvert == 2)
{
    Console.WriteLine("Х<0, Y>0");

}
if (chetvert == 3)
{
    Console.WriteLine("Х<0, Y<0");

}
if (chetvert == 4)
{
    Console.WriteLine("Х>0, Y<0");

}
if (chetvert < 1 || chetvert > 4)
{
    Console.WriteLine("Неверный номер четверти");

}


/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */
// не решили:
Console.WriteLine("Введите координаты точки А:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В:");
int y = Convert.ToInt32(Console.ReadLine());
double ab = Math.sqrt(sqrt(x2 - x1) + sqrt(y2 - y1));

//Чужой вариант:
Console.WriteLine("Введите хa:");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ya:");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите хb:");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите yb:");
int yb = Convert.ToInt32(Console.ReadLine());

double S = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));

Console.WriteLine(S);

//Решение Вадима:
Math.Pow(x2 - x1, 2); возведение в степень
Math.Sqrt (49) квадратный корень

Console.WriteLine("Введите х1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2 - x1, 2)) + Math.Sqrt(Math.Pow(y2 - y1, 2));
Console.WriteLine(d);


/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= n)
{
    Console.WriteLine(Math.Pow(index, 2));
    index++;
}

Чужие варианты:
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
while (count <= number)
{
    double result = Math.Pow(count, 2);
    Console.WriteLine(result);
    count++;
}

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= number; count++)
{
    double result = Math.Pow(count, 2);
    Console.WriteLine(result);
}
