﻿/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, */

//int N=5;
int N=8;
int S=0;
while(S<N)
{
    S+=2;
    Console.WriteLine($"Число = {S}");    
}
 

