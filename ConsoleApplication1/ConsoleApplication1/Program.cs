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
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();
            Regex rgx = new Regex(@"^\D{1}[а-яА-Яa-zA-Z0-9]{1,9}$");
            if(rgx.IsMatch(login))
                Console.WriteLine("Логин верен");
            else
                Console.WriteLine("Логин не верен");
            Console.ReadKey();
        }
    }
}
