using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public struct Point3D
        {
            int x;
            int y;
            int z;
            public Point3D(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public static Point3D operator +(Point3D p1, Point3D p2)
            {
                Point3D p3 = new Point3D(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
                return p3;
            }
            public static Point3D operator -(Point3D p1, Point3D p2)
            {
                Point3D p3 = new Point3D(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
                return p3;
            }
            public void Show()
            {
                Console.WriteLine("({0},{1},{2})", this.x, this.y, this.z);
            }
        }

        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1, 1, 1);
            Point3D p2 = new Point3D(2, 3, 4);
            Point3D p3 = new Point3D();
            Console.WriteLine("Выберите действие\n1)Сложить координаты\n2)Вычесть координаты первой точки из второй\n3)Вычесть координаты второй точки из первой");
            int res = Int32.Parse(Console.ReadLine());
            switch (res)
            {
                case 1:
                    p3 = p1 + p2;
                    Console.Write("Результатом сложения точек (1,1,1) и (2,3,4) является точка ");
                    p3.Show();
                    break;
                case 2:
                    p3 = p1 - p2;
                    Console.Write("Результатом вычитания точек (1,1,1) и (2,3,4) является точка ");
                    p3.Show();
                    break;
                case 3:
                    p3 = p2 - p1;
                    Console.Write("Результатом вычитания точек (2,3,4) и (1,1,1) является точка ");
                    p3.Show();
                    break;
                default:
                    Console.WriteLine("Неверно выбран пункт");
                    break;
            }
            Console.ReadKey();
        }
    }
}
