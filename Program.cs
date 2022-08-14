//Задача 13:Напишите программу, которая выводит третью (заданную) цифру заданного числа или сообщают, что третьей цыфры нет.
using static System.Console;
int digitCount(int digit)//подсчет кол-ва цифр
{
    int counter = 0;
    while (digit != 0)
    {
        digit /= 10;
        counter++;
    }
    return counter;
}

WriteLine("Enter the number");
int digit = int.Parse(Console.ReadLine());
WriteLine("What is the digit of this number?");
int number = int.Parse(Console.ReadLine());


if (digitCount(digit) <= -number || digitCount(digit) >= number)
{
    for (int i = 0; i < digitCount(digit); i++)
    {
        digit = (int)(digit / Math.Pow(10, (digitCount(digit) - number)));
        digit %= 10;
    }
    Console.WriteLine($"{number} number is  {digit}");
}
else Console.WriteLine($"{number} number is not included {digit}");
