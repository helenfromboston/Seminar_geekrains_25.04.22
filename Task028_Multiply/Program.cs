// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 1; i <= number; i++)
{
    result = result * i;
}

Console.WriteLine($"Произведение чисел от 1 до {number} равно {result}");