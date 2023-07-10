// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Input("Введите трёхзначное число: ");
if (number > 99 & number < 1000)
{
    int number_s = number / 10 % 10;
    Console.WriteLine(number_s);
}
else Console.WriteLine("Введено некорректное число");


