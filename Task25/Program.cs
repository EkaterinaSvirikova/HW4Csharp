// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;

Clear();

Write("Введите число А: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int B = Convert.ToInt32(ReadLine());
WriteLine();

int answer = GetInPower(A, B);
WriteLine($"Ответ: {A} в степени {B} = {answer}");
WriteLine();

int GetInPower(int number, int power)
{
    int result = 1;
    for(int i = 1; i <= power; i++)
    {
        result = result * number;

    }
    return result;  
}