﻿// Задача 1: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник с сторонами такой длины.



int[]  RandomArrGen()
{
    int length = 3;
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        System.Console.WriteLine($"{arr[i]}");
    }
    return arr;
}
bool CheckTriangle(int[] arr)
{
    if(arr[0] + arr[1] < arr[2]) return false;
    if(arr[0] + arr[2] < arr[1]) return false;
    if(arr[2] + arr[1] < arr[0]) return false;
    return true;
}

int[] triangle = RandomArrGen();
System.Console.WriteLine(CheckTriangle(triangle));