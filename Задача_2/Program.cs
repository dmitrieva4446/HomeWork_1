// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.Write($"Большее число {a}");
else
    Console.Write($"Большее число {b}");