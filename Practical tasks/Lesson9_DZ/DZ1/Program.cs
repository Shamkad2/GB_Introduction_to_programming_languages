// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"



Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
for (int i = n; i <= m; i++)
    {
        if (i % 2 == 0) 
        {
            Console.Write(i + " ");
        }
    }
Console.ReadKey();