// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

using System;
using static System.Console;
Clear();

WriteLine("Please type a number from 1 to 7");
int number = Convert.ToInt32(ReadLine());

if ((number<1) || (number>7)) {WriteLine($"{number} - this is not a number from 1 to 7");
                                    return;}

WriteLine(number==6 || number==7? $"This is a day off"
: $"This is a working day");