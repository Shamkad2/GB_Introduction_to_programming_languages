﻿// Решение в группах задач:
// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да





Console.Clear();


int[] CreateArray(int len, int minLimit, int maxLimit)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minLimit, maxLimit+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool SpecifedNumber(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == value)
        {
            return true;
        }
    }
    return false;
}


int[] array = CreateArray(8, -9, 9);
PrintArray(array);
int value = Prompt("Введите число: ");
Console.WriteLine((SpecifedNumber (array, value)));

