// // разбор домашней задачи 19
// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);

// if (num >= 10000 && num < 100000)
// {
//     if (result[0] == result[4] && result[1] == result[3])
//     {
//         Console.WriteLine("Это палиндром");
//     }
//     else
//     {
//         Console.WriteLine("Это не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine("Ошибка! Вы ввели не пятизначное число");
// }


/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сумма = " + GetSum(num)); // вызов метода можно размещать как выше так и ниже описания метода в коде


// int GetSum(int number) // здесь можно любое название пер, в т.ч. num
// {
//     int sum = 0;
//     int count = 0;
//     while (number > count)
//     {
//         count++;
//         sum += count; // sum=sum+count
//     }
//     return sum; // return заканчивает метод и выводит значение, которое должен выдать метод
// }

/* Самостоятельная работа
Задача 1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */
// // Наш вариант:
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// Console.WriteLine("количество цифр=" + KolvoCifr(result));

// int KolvoCifr(string num)
// {
//     int size = num.Length;
//     return size;
// }

// // Вариант Вадима:
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Колличество цифр = " + GetCount(num));

// int GetCount(int number)
// {
//     int count = 0;
//     while (number > 0) 
//     {
//         count++;
//         number /= 10; // делим введенное число на 10

//     }
//     return count; // выводит, сколько раз сработал цикл

// }

// // еще вариант: 
// string num = Console.ReadLine();
// int CountingDigits(string num)
// {
//     return num.Length;
// }
// Console.WriteLine(CountingDigits(num));

/* Задача 2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */
// // Наш вариант с помощью for:
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Произведение = " + GetProd(num)); // вызов метода можно размещать как выше так и ниже описания метода в коде


// int GetProd(int number) // здесь можно любое название пер, в т.ч. num
// {
//     int prod = 1;
//     for (int count = 1; count <= number; count++)
//     {
//         prod *= count; // prod = prod * count;
//     }
//     return prod; // return заканчивает метод и выводит значение, которое должен выдать метод
// }

// Чужой вариант с помощью while:
// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num + " -> " + GetSum(num));

// int GetSum(int number)
// {
//     int pr = 1;
//     int count = 0;
//     while (number > count)
//     {
//         count++;
//         pr *= count;
//     }
//     return pr;
// }

// //Чужой с for:
// int num = Convert.ToInt32(Console.ReadLine());

// int GetProduct(int num)
// {
//     int prod = 1;
//     for(int i = 1; i <= num; i++)
//     {
//         prod*=num;
//     }

//     return prod;
// }

// Console.WriteLine(GetProduct(num));

/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
// // не сделали:
// int[] array;

// int Arr(int[] array1)
// {
//     size = array1.Length;
//     int a = Random(0, 1);
//     for (int i = 0; i < size; i++)
//     {
//         array1[i] =
//     }
// }

// //Вариант Дианы:
// int[] array = new int[8]; //создание нулевого массива

// // заполняем массив
// void FillArray(int[] collection) //передает пустой массив
// {
//     int length = collection.Length; //находит длину этого массива и передает в пер.length
//     int index = 0;
//     while (index < length) //заполняет массив
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// // выводим массив
// void PrintArray(int[] col) //передает 
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position + ", "]);
//         position++;
//     }
// }

// FillArray(array);
// PrintArray(array);

//Вариант Вадима:
int []array = GetArray(8);
Console.WriteLine(string.Join(",",array));

int [] GetArray(int size)
{
    int [] result = new int [size];
    for(int i=0; i< size;i++)
    {
        result[i] = new Random().Next(0,2);


    }
    return result;

}
