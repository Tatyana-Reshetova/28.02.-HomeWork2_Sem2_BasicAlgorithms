﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int a = num/10;
int result = a%10;
Console.WriteLine($"Второе число трезначного числа {num} - > {result}");
