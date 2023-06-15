// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели");

string? strnumber = Console.ReadLine();

int number = Convert.ToInt32(strnumber);
 


if (number>7 || number <= 0)
{
    Console.WriteLine("Такого дня недели нет");

}
else
{
if (number > 5)
{
        Console.WriteLine("Это выходной");

}
else
{
        
    Console.WriteLine("Это НЕ! выходной");

}

    
}