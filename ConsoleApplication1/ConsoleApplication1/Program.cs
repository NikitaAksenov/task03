using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex rgx = new Regex(@"^stdLog$");
            Console.Write("Введите логин:");
            string str = Console.ReadLine();
            if (rgx.IsMatch(str))
                Console.WriteLine("Логин верен");
            else
                Console.WriteLine("Логин не верен");
            Console.ReadKey();
        }
    }
}
