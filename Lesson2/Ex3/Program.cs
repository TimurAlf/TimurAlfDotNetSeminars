﻿//Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если 2 число не кратно число 1 программа
//выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
void mod()
{
int a=16;
int b= 4;
int c= a%b;

if(c==0)
{
Console.WriteLine("кратно");
}
else
{
    Console.Write("не кратно, остаток ");
    Console.Write(c);
}
}
mod();