﻿// Дз №1

// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23
// Пример
// a = 50 => нет
// a = 7 => нет
// a = 322 => да

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a % 7 == 0 && a % 23 == 0)
// {
//     Console.Write("Кратно ");
// }
// else
// {
//     Console.Write("Не кратно ");
// }

//.......................................................................

// Дз №2

// Напишите программу, которая принимает на вход координаты 
// точки (X и Y) причем X не != 0  и Y != 0 и выдаёт номер 
// координатной четверти плоскости, в которой находится эта точка.

// 1ч (+;+)
// 2ч (-;+)
// 3ч (-;-)
// 4ч (+;-)


// Console.Clear();
// Console.Write("Введите число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int y = Convert.ToInt32(Console.ReadLine());

// while(x == 0 || y == 0)
// {
//     Console.Write("Ошибка, введите число: ");
//     x = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число: ");
//     y = Convert.ToInt32(Console.ReadLine());
// }

// if (x > 0 && y > 0)
// {
//     Console.Write("Значения принадлежат 1 четверти");
// }
// if (x < 0 && y > 0)
// {
//     Console.Write("Значения принадлежат 2 четверти");
// }
// if (x < 0 && y < 0)
// {
//     Console.Write("Значения принадлежат 3 четверти");
// }
// if (x > 0 && y < 0)
// {
//     Console.Write("Значения принадлежат 4 четверти");
// }





// Дз №3

// Напишите программу которая принимает на вход целое число из отрезка
// [10,99] и показывает наибольшую цифру числа.

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// while(a < 10 || a > 99)
// {
//     Console.Write("Ошибка, введите число: ");
//     a = Convert.ToInt32(Console.ReadLine());
// }
// int n1 = a / 10;
// int n2 = a % 10;
// int max = n1;

// if (n1 <= n2){
//     max = n2;
// }
// Console.Write(max);

// ......................................................................


// Дз №4

// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую  


// Console.Clear();
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int a1 = a;
// int i = 1;
// while (a1 >= 10)
// {
//     a1 = a1 / 10;
//     i = i * 10;
// }
// while (i > 1)
// {
//     Console.Write(a / i % 10 + ", ");
//     i = i / 10;
// }
// Console.Write(a % 10);

