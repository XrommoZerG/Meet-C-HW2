// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



// Задание 10



Console.WriteLine("Введите трёхзначну цифру");

string? strnumber = Console.ReadLine();

int number = Convert.ToInt32(strnumber);

int otv = (number / 10) % 10;

Console.WriteLine(otv);

