// Задача 4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.Write($"Максимальное число {a}");
else if (b > c)
    Console.Write($"Максимальное число {b}");
else if (c > a)
    Console.Write($"Максимальное число {c}");
