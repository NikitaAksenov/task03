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
            string stdString = "Сегодня металлурги Саратовской области из компании \"Росметалл\" выполнили двукратную норму по сдаче металла. И рубили металл при этом";
            Regex rgx = new Regex(@"[а-яА-Я]*(металл)[а-яА-Я]*");
            foreach (Match match in rgx.Matches(stdString))
            {
                Console.WriteLine("Нашёл '{0}'", match.Value);
            }
            Console.ReadKey();
        }
    }
}
