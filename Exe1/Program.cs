// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 > 10)
    {
      char[] data= num1.ToString().ToArray();
      Console.WriteLine($"{data[1]} -> Второе число");
    }
else 
    {
       Console.WriteLine("Второго числа нет");
    }
