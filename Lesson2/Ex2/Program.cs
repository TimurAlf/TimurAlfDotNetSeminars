//Напишите программу, которая выводит случайное трехзначное число 
//и удаляет 2 цифру этого числа.
//456 -> 46
//782-> 72
//918 -> 98

int val = new Random().Next(100, 1000);
int a = val/100;
int b = val%10;

Console.WriteLine(val);
Console.Write(a);
Console.Write(b);