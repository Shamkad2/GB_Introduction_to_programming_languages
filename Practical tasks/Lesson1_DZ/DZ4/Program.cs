// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
        Console.Write("Чётные числа от 1 до ");
}

int i = 2;

while(i <= num)
{
    if (i%2 == 0)

    {Console.Write(i + " ");}
    i ++;
}
            