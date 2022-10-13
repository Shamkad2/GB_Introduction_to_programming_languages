// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D 
// пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21



Console.Clear();
//Math.Sqrt(); //вычисление квадратного корня

const int x = 0;
const int y = 1;

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int [] InputPoint (int point)
{
    int[] answer = new int [2];
    answer[x] = Prompt($"Введите x1 {point} -> ");
    answer[y] = Prompt($"Введите y1 {point} -> ");
    return answer;
}
int Power2 (int arg)
{
    return arg * arg;
}
int [] p1 = InputPoint(1);
int [] p2 = InputPoint(2);

double lenght = Math.Sqrt (Power2(p1[x] - p2[x])+Power2(p1[y] - p2[y])); // <- Math.Sqrt

System.Console.WriteLine($"{lenght:f2}"); // f - количество знаков после запятой
