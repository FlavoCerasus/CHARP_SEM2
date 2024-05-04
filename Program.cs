/* Задача 1 - Напишите программу, которая принимает на вход трёхзначное число
и удаляет вторую цифру этого числа.
Примеры:
a = 256 => 26
a = 891 => 81
*/
/*
int num_task1 = 256;
int first_digit = num_task1 / 100; // first_digit = 2
int third_digit = num_task1 % 10; // third_digit = 6
int res_1 = first_digit * 10 + third_digit; // result = 2 * 10 + 6
Console.WriteLine(result);
*/

/* Задача 2 - Напишите программу, которая принимает на вход трёхзначное число 
и возводит вторую цифру этого числа в степень, равную третьей цифре.
Примеры:
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1
*/
/*
int num_task2 = 487;
int second_digit = num_task2 / 10 % 10; // second_digit = 487 / 10 % 10 => 48 % 10 => 8
int third_digit = num_task2 % 10; // third_digit = 7
double res_2 = Math.Pow(second_digit, third_digit); // 1-е - основание степени, 2-е показатель степени => 7^8
// Math - это математическая библиотека, Pow - возведение в степень
Console.WriteLine(res_2);
*/

/* Задача 3 - Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число некратно первому, 
то программа выводит остаток от деления.
Примеры:
14, 5 => нет, 4
16, 8 => да
4, 3 => нет, 1
*/
/*
int num_1 = 14;
int num_2 = 5;
if (num_1 % num_2 == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine($"Первое число не кратно второму, остаток - {num_1 % num_2}");
}
*/

/* Задача 4 - Напишите программу, которая выводит третью с конца цифру заданного числа 
или сообщает, что третьей цифры нет.
456 => 6
7812 => 1
91 => Третьей цифры нет
*/
/*
int num_task4 = 781312;
if (num_task4 < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else 
{
    while (num_task4 > 999)
    {
        num_task4 /= 10; // num_task4 = num_task4 / 10
    }
    int res_4 = num_task4 % 10;
    Console.WriteLine(res_4);
}
*/

// Домашнее задание!

/* Задание 1 - Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
*/
/*
Console.Write("Введите число number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.Write("Число кратно обоим числам");
}
else
{
    Console.Write("Число не кратно одному или обоим числам");
}
*/

/* Задание 2 - Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
*/
/*
Console.Write("Введите координату X: ");
int coor_X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int coor_Y = Convert.ToInt32(Console.ReadLine());
if (coor_X == 0 || coor_Y == 0)
{
    Console.Write("Не удалось найти четверть плоскости, повторите программу и ведите координаты заново!");
}
else 
{
    if (coor_X > 0)
    {
        if (coor_Y > 0 )
        {
            Console.Write("Точка соответствует I четверти");
        }
        else 
        {
        Console.Write("Точка соответствует IV четверти");
        }
    }
    else 
    {
         if (coor_Y > 0 )
        {
            Console.Write("Точка соответствует II четверти");
        }
        else 
        {
        Console.Write("Точка соответствует III четверти");
        }
    }
}
*/

/* Задание 3 - Напишите программу, которая принимает на вход целое число 
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
/*
Console.Write("Введите число от 10 до 99: ");
int number_hw_3 = Convert.ToInt32(Console.ReadLine());
int second_digit_hw_3 = number_hw_3 %10;
int first_digit_hw_3 = number_hw_3 / 10;
if (first_digit_hw_3 >= second_digit_hw_3)
{
    Console.WriteLine($"Большее число {first_digit_hw_3}");
}
else 
{
    Console.WriteLine($"Большее число {second_digit_hw_3}");
} 
// int maxDigit = first_digit_hw_3 > second_digit_hw_3 ? first_digit_hw_3 : second_digit_hw_3;
// Console.WriteLine(maxDigit);
*/

/* Задание 4 - Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.
*/

/*
Console.Write("Введите число: ");
int number_hw_4 = Convert.ToInt32(Console.ReadLine());
while(number_hw_4 > 10)
{
    int digit = number_hw_4 % 10;
    Console.Write($"{digit}, ");
    number_hw_4 /= 10;
}
Console.Write(number_hw_4);
*/