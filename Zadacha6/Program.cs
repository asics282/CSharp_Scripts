﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Является ли число введенное вам целым?");
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
if ( x % 2 == 0) {Console.WriteLine("Да");}
else {Console.WriteLine("Нет");}