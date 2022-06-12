// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using System;
using static System.Console;
Clear();

WriteLine("Please type a positive 3-digits number");
int number = Convert.ToInt32(ReadLine());

if ((number<100) || (number>999)) {WriteLine($"{number} - this is not a positive 3-digits number");
                                    return;}
else
{
    int digitsOneTwo = number%100;
    int digitTwo = digitsOneTwo/10;

WriteLine($"Second digit of the number is {digitTwo}");
}