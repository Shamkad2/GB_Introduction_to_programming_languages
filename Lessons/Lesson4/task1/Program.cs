// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Ввод числа по приглашению
int InputNumber(string message)
{
    Console.Write(message);                     //Вывод приглашения 
    string str = Console.ReadLine();            //Читаем строку с консоли
    return int.Parse(str);                //Преобразуем строку в число
}


//Сумма чисел от 1 до number
int SumNumbers(int number)
{
    int sum = 0;                            //Тут накапливаем сумму
    for(int i = 1; i <= number; i++)        //Цикл от 1 до number
    {
        sum = sum + i;                      //суммируем
    }
    return sum;                             //возврат суммы из метода
}


// проверка на правильность ввода
bool ValidateNumber(int number)
{
    if (number < 1)     //При числе меньше чем 1 не работаем
    {
        System.Console.WriteLine("Число меньше единицы, сумма не считается");
        return false;
    }
    return true;
}

int n = InputNumber("Введите число >");     //вводим номер
if (ValidateNumber(n))          //проверяем номер на правильность
{
    int result = SumNumbers(n);     //в результат отправляем сумму чисел с параметром
    System.Console.WriteLine($"Сумма чисел от 1 до {n} равна {result}");    //напечатай строку со следующими параметрами
}