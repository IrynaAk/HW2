// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using System;
using static System.Console;
Clear();

WriteLine("Please type a number");
int number = Convert.ToInt32(ReadLine());

WriteLine(Math.Abs((number%1000)/100)>0? $"The third digit is {Math.Abs((number%1000)/100)}"
: $"There is no third digit in the number");
