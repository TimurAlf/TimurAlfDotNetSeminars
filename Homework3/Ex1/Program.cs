﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Num = new Random().Next(10000, 99999);
int a = Num % 100;
int b = Num / 1000;
if(a==b) System.Console.WriteLine("Число " +Num+ " является палиндромом. ");
else System.Console.WriteLine("Число " +Num+ " не является палиндромом. ");