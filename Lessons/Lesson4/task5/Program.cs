﻿// Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального 
// элемента, но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5


int[] arr = {1, 2, 3, 4, 5, 55, 621, 2};

int max = arr[0];
int second_max = arr[3];

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
}

Console.WriteLine(max);
Console.WriteLine(second_max);