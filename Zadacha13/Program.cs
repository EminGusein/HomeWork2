﻿// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = new Random().Next();
// int number = Input("Введите любое число: ");
Console.WriteLine($"Случайное число = {number}");
int count = 10;
while (number > 999)
{
    number = number / count;
    count = count * 1;
}
if (number > 99)
{
    int number_t = number % 10;
    Console.WriteLine($"Третья цифра в числе - {number_t}");
}
else Console.WriteLine($"Третьей цифры нет");