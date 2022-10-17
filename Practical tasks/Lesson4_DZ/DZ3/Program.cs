// Задача 3: Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8


int lenArray = ReadInt("Введите любое число и получите массив из 8 случайных элементов: ");

int[] randomArray = new int[8];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,29);
    Console.Write(randomArray[i] + " ");
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

