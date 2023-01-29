// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте узнаем все четные числа от 1 до вашего, введите число:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            Console.WriteLine("Четные числа:");

            while (res < num1)
            {
             Console.WriteLine(res+1);
            res+= 2;
            }
        }     
    }

