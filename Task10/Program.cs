﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int raz = 0;
int dva = 0;
raz = num / 10;
dva = raz % 10 ;

Console.WriteLine(dva);
