// Задача 3: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}


int[] myArray = CreateArray(10, 0, 200);
PrintArray(myArray);

int CountNumbers(int[] myArray)
{
    int count = 0;

    for (int i = 0; i < myArray.Length; i++)
    {
        if(myArray[i] >= 10 && myArray[i] <= 99)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine($"Количество двузначных элементов, которые лежат в отрезке [10-99]: {CountNumbers(myArray)}");

