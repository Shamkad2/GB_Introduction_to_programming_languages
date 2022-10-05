// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B );    
}

if (num_B > num_A)
{
    Console.WriteLine("Первое число " + num_B + " больше чем второе " + num_A );    
}
            
if (num_B == num_A)
{
    Console.WriteLine($"{num_B} и {num_A} равны");
}
