// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
 
            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Наибольшее число");
                Console.WriteLine($"Max={num1}");
            }     
            else if (num2>num3)
            {
                Console.WriteLine("Наибольшее число");
                Console.WriteLine($"Max={num2}");
            }
            else
            {
                Console.WriteLine("Наибольшее число");
                Console.WriteLine($"Max={num3}");
            }
            Console.ReadKey();
        }
    }