using System;
using System.Linq.Expressions;

namespace MyDowbleTranseption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string num = Console.ReadLine();
            while(true)
            {
                try
                {
                    int num0 = Convert.ToInt32(num);
                    break;
                }
                catch
                {
                    Console.WriteLine("Это не число, дурашка)");
                    Console.WriteLine("Введите число:");
                    num = Console.ReadLine();
                }
            }
            Console.WriteLine("Это число представлено в двоичной(1) или десятичной(2) системе счисления? Введите соответствуюшее число");
            string select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    Console.WriteLine("Вы выбрали 1 вариант. Перевожу ваше число в десятичную форму");
                    int morfnum = Convert.ToInt32(num);
                    int i = 0;
                    int result = 0;
                    while (morfnum >= 0)
                    {
                        int razriad = morfnum % 10;
                        if (razriad > 1)
                        {
                            Console.WriteLine("Ты шутишь, это не двоичное число");
                            return;
                        }
                        int promnum = razriad * Convert.ToInt32(Math.Pow(2, i));
                        i += 1;
                        result += promnum;
                        morfnum /= 10;
                    }
                    Console.WriteLine($"Ваш результат = {result}");
                    Console.ReadKey();
                    return;

                case "2":
                    Console.WriteLine("Вы выбрали 2 вариант. Перевожу ваше число в двоичную форму");
                    int dowblenum = Convert.ToInt32(num);
                    string binarycode = Convert.ToString(dowblenum, 2);
                    Console.WriteLine($"Ваш результат = {binarycode}");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Не стоило тебе сюда приходить и шутки тут свои шутить =( =( ");
                    break;
            }
        }
    }
}
