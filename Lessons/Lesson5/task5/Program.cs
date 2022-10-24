// Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




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


int[] myArray = CreateArray(10, 0, 5);
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

int[] secondArray;

if (myArray.Length % 2 == 0 )
{
    secondArray = new int[myArray.Length / 2];
}

else 
{
    secondArray = new int[myArray.Length / 2 + 1];
}

for (int i = 0; i < myArray.Length / 2; i++)
{
    secondArray[i] = myArray[i] * myArray[myArray.Length - 1 - i];
}

if (myArray.Length % 2 != 0)
{
    secondArray[secondArray.Length - 1] = myArray[secondArray.Length - 1];
}




PrintArray(secondArray);