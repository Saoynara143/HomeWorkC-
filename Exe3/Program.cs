﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели(от 1 до 7):");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 >= 6 && num1 <= 7)
    {
      Console.WriteLine($"{num1} -> Да, это выходной день");
    }
else if (num1>7)
    {
     Console.WriteLine("Вы ввели не верное число");
    }
else 
    {
       Console.WriteLine($"{num1} -> Нет, это рабочий день");
    }