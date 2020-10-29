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
                    double num0 = Convert.ToDouble(num);
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
                    decimal morfnum = Convert.ToDecimal(num);
                    int i = 0;
                    decimal result = 0;
                    while (morfnum > 0)
                    {
                        decimal razriad = morfnum % 10;
                        if (razriad > 1)
                        {
                            Console.WriteLine("Ты шутишь, это не двоичное число");
                            return;
                        }
                        decimal promnum = razriad * Convert.ToDecimal(Math.Pow(2, i));
                        i += 1;
                        result += promnum;
                        morfnum = Math.Truncate(morfnum / 10);
                    }
                    Console.WriteLine($"Ваш результат = {result}");
                    Console.ReadKey();
                    return;

                case "2":
                    Console.WriteLine("Вы выбрали 2 вариант. Перевожу ваше число в двоичную форму");
                    double dowblenum = Convert.ToDouble(num);
                    string binarycode = Convert.ToString((short)dowblenum, 2);
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
