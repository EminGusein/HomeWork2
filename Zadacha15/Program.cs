// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int day = Input("Введите цифру, обозначающую день недели: ");
if (day < 1 || day > 7) Console.WriteLine("Такого дня недели не существует");
else if (day == 6 || day == 7) Console.WriteLine("День является выходным");
else Console.WriteLine("День является рабочим");