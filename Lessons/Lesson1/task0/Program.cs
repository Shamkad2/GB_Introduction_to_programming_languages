// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя). Например: 
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     string inputString = Console.ReadLine();
//     int value = Convert.ToInt32(inputString);
//     return value;
// }

// int value = Prompt("Введите число >");
// int square = value * value;
// System.Console.WriteLine($"Квадрат числа {value} равен {square}");


// 1. Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом 
// второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да


Console.WriteLine ("Введите первое число: "); // Выводим фразу
int a = Convert.ToInt32(Console.ReadLine()); // Считываем из консоли
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); // convert.ToInt это функция которая преобразовывает строку в целое число
if (a == b*b) // условие
{
    Console.WriteLine ($"Число {a} является квадратом {b}.");
}
else if (b == a*a)
{
    Console.WriteLine ($"Число {b} является квадратом {a}.");
}
else
{
    Console.WriteLine ($"Числа не являются квадратами друг друга");
}
