// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6






Console.WriteLine("Введите цифру");

string? strnumber = Console.ReadLine();

int number = Convert.ToInt32(strnumber);

Console.WriteLine("Какую цыфру вы хотите получить ");

string? strindex = Console.ReadLine();

int indexe = Convert.ToInt32(strindex);



//int indexe = 3;

int otv = 0;

if (indexe > strnumber.Length)
{
    Console.WriteLine("Ввашей цифре нет столько цыфр");
    Console.WriteLine("Длина строки: " + strnumber.Length);

}
else if (indexe == strnumber.Length)
{
    otv = number % 10;
    Console.WriteLine("Ответ" + otv);
    
}
else
{
    for (int i = 0; i < strnumber.Length - (indexe - 1) ; i++)
    {
        otv = number % 10;
        number /=10;
    }
    Console.WriteLine("Ответ: " + otv);
    //Console.WriteLine("Длина строки: " + strnumber.Length);
}



