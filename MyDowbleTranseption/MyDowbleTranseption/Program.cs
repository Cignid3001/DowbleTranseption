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
                    int i = 1;
                    double goodnum = 0;
                    for (int k = 0; k < num.Length; k++)
                    {
                        if (Convert.ToInt32($"{num[k]}") > 1 || Convert.ToInt32($"{num[k]}") < 0)
                        {
                            Console.WriteLine("Это не двоичное число.");
                            return;
                        }
                    }
                    while (i <= num.Length)
                    {
                        int susanna = Convert.ToInt32($"{num[num.Length - i]}");
                        goodnum += susanna * Math.Pow(2, i - 1);  
                        i += 1;
                    }
                    Console.WriteLine($"Ваш результат = {goodnum}");
                    Console.ReadKey();
                    return;

                case "2":
                    Console.WriteLine("Вы выбрали 2 вариант. Перевожу ваше число в двоичную форму");
                    int dowblenum = Convert.ToInt32(num);
                    /*string binarycode = Convert.ToString((short)dowblenum, 2);
                    Console.WriteLine($"Ваш результат = {binarycode}");*/
                    string itog = "";
                    while (dowblenum > 2)
                    {
                        itog = Convert.ToString(dowblenum % 2) + itog;
                        dowblenum = dowblenum / 2;
                    }
                    itog = 1 + itog;
                    Console.WriteLine($"Ваше чиосло - {itog}");
                    Console.ReadKey();
                    return;



                default:
                    Console.WriteLine("Не стоило тебе сюда приходить и шутки тут свои шутить");
                    break;
            }
        }
    }
}
