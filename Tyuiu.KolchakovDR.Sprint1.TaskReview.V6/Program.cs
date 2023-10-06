using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskHeaderGenerator;
using Tyuiu.KolchakovDR.Sprint1.TaskReview.V6.Lib;
namespace Tyuiu.KolchakovDR.Sprint1.TaskReview.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            TaskHG thg = new TaskHG(
                1,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "SprintReview #1 ЗАДАНИЕ",
                7,
                6,
                "Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой.");
            thg.printHeader();
            Console.WriteLine("");
            Console.WriteLine(" Формула: z=(1 + (1 / x^2)^x - 12 * x^2 * y");
            Console.WriteLine("");

            Console.WriteLine("Введите число Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            
            thg.printFooter();

            Console.WriteLine("Z = " + ds.Calculate(x, y));

            Console.ReadKey();


        }
    }
}
