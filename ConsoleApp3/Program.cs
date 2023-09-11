using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do 
            {
                Console.WriteLine("1. Сложить 2 числа");
                Console.WriteLine("2. Вычесть первое из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал из числа");
                Console.WriteLine("9. Выйти из программы");
                Console.WriteLine("Какую операцию хотите выполнить?");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 1)
                {
                    Console.WriteLine("Введите 2 числа ");
                    int od = 0;
                    int dv = 0;
                    int.TryParse(Console.ReadLine(), out od);
                    int.TryParse(Console.ReadLine(), out dv);
                    int sum = od + dv;
                    Console.WriteLine(od + "+" + dv + "=" + sum);
                }
                else if (x == 2)
                {
                    Console.WriteLine("Введите 2 числа ");
                    int od = 0;
                    int dv = 0;
                    int.TryParse(Console.ReadLine(), out od);
                    int.TryParse(Console.ReadLine(), out dv);
                    int sum = od - dv;
                    Console.WriteLine(od + "-" + dv + "=" + sum);
                }
                else if (x == 3)
                {
                    Console.WriteLine("Введите 2 числа ");
                    int od = 0;
                    int dv = 0;
                    int.TryParse(Console.ReadLine(), out od);
                    int.TryParse(Console.ReadLine(), out dv);
                    int sum = od * dv;
                    Console.WriteLine(od + "*" + dv + "=" + sum);
                }
                else if (x == 4)
                {
                    Console.WriteLine("Введите 2 числа ");
                    int od = 0;
                    int dv = 0;
                    int.TryParse(Console.ReadLine(), out od);
                    int.TryParse(Console.ReadLine(), out dv);
                    int sum = od / dv;
                    Console.WriteLine(od + "/" + dv + "=" + sum);
                }
                else if (x == 5)
                {
                    Console.WriteLine("Введите 2 числа ");
                    int od = 0;
                    int dv = 0;
                    int.TryParse(Console.ReadLine(), out od);
                    int.TryParse(Console.ReadLine(), out dv);
                    double sum = Math.Pow(od, dv);
                    int f = Convert.ToInt32(sum);
                    Console.WriteLine(od + " в степени " + dv + " = " + f);
                }
                else if (x==6) 
                {
                    Console.WriteLine("Введите число ");
                    int od = 0;
                    int.TryParse(Console.ReadLine(), out od);
                    double sum = Math.Sqrt(od);
                    Console.WriteLine("Корень из " + od + " = " + sum);
                }
                else if (x == 7)
                {
                    Console.WriteLine("Введите число ");
                    int od = 0;
                    int.TryParse(Console.ReadLine(), out od);
                    int sum = od / 100;
                    Console.WriteLine("Один процент от " + od + " = " + sum);
                }
                else if (x == 8)
                {
                    Console.WriteLine("Введите число ");
                    int od = 0;
                    int sum = 1;
                    int.TryParse(Console.ReadLine(), out od);
                    for (int i = 1; i<=od; i++)
                    {
                        sum = sum * i;
                    }
                    Console.WriteLine("Факториал " + od + " = " + sum);
                }
            }
            while (x<=8);
        }
    }
}