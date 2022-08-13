//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является лиэтот день выходным.
using static System.Console;
bool isHoliday(int day) { return day>5 ? true : false; }
int day;
do
{
    Write("Enter a number for the day of the week: ");
    day = int.Parse(Console.ReadLine());
} while (day > 7||day<1);

Write($"Is this day off? ");
if (isHoliday(day)) Write("Yes");
else Write("No.");