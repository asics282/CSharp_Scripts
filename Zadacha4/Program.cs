﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberC = int.Parse(Console.ReadLine());
Console.WriteLine("Вы ввели: " + numberA + ", " + numberB + ", " + numberC);

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("Максимальным из чисел " + numberA + ", " + numberB + ", " + numberC + " является число ");
Console.WriteLine(max);