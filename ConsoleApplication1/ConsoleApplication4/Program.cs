using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -3;
            long y = 46129521;
            double z = -34.12;
            Mod(x);
            Mod(y);
            Mod(z);
            Console.ReadKey();
        }

        public static void Mod(int x)
        {
            Console.WriteLine("Модулем числа {0} является {1}", x, Math.Abs(x));
        }
        public static void Mod(long x)
        {
            Console.WriteLine("Модулем числа {0} является {1}", x, Math.Abs(x));
        }
        public static void Mod(double x)
        {
            Console.WriteLine("Модулем числа {0} является {1}", x, Math.Abs(x));
        }
    }
}
