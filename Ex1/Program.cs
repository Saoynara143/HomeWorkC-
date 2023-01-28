// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
 
            if(num1 > num2)
            {
                Console.WriteLine("Первое число больше второго числа");
                Console.WriteLine($"Max={num1}; Min={num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Второе число больше первого числа");
                Console.WriteLine($"Max={num2}; Min={num1}");
            }
            else
            {
                Console.WriteLine("Эти числа равны");
                Console.WriteLine($"{num1}={num2}");
            }
            Console.ReadKey();
        }
    }