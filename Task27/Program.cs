// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int A = Convert.ToInt32(ReadLine());
WriteLine();

int answer = GetSum(A);
WriteLine($"Сумма всех цифр числа {A} = {answer}");
WriteLine();

int GetSum(int number)
{
    int count = Convert.ToString(number).Length;
    int temp = 0;
    int result = 0;

    for(int i = 0; i < count; i++)
    {
        temp = number - number % 10;
        result = result + (number - temp);
        number = number / 10;
    }
    return result;
}
