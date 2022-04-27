// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите два числа: ");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 1; i <= B; i++)
{
    result = result * A;
}
Console.WriteLine($"{A} в степени {B} равно {result}");