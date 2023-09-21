using System;
// Напишите команду которая на вход принемает число и выдает его квадрат 
//(число умноженное само на себя)
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int str = number * number;
Console.Write("Квадрат числа");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);
Console.WriteLine();

// Вывод с использованием знака $
Console.WriteLine($"Квадрат числа {number} равен = {str}");

// Использование библиотеки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqr_2 = Math.Pow(sqr, 2);
Console.WriteLine($"Квадрат числа {number} равен = {sqr} , {sqr_2} ");
