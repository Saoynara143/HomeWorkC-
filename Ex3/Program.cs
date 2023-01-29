// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверьте является ли ваше число четным. Введите любое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
 
            if((num1 % 2) == 0)
            {
                Console.WriteLine($"{num1} -> Да, оно четное");
            }     
            else
            {
                Console.WriteLine($"{num1} -> Нет, оно нечетное");
            }
            Console.ReadKey();
        }
    }
