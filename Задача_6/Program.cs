﻿// Задача 6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());

if (a%2==0)
    Console.Write($"Четное число {a}");
else 
    Console.Write($"Нечетное число {a}");