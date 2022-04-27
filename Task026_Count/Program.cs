// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 0;

while (number > 0)
{
    number = number / 10;
    count++;
}

Console.WriteLine($"В данном числе {count} цифр");