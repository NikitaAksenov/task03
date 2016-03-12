using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки");
            string str = Console.ReadLine();
            Regex rgx = new Regex(@"[а-яА-Я]*((м|М)еталл)[а-яА-Я]*");
            if (rgx.IsMatch(str))
            foreach(Match match in rgx.Matches(str))
                Console.WriteLine("Нашёл '{0}'", match.Value);
            else
                Console.WriteLine("Вхождений слова \"металл\" не найдено");
            Console.ReadKey();
        }
    }
}
