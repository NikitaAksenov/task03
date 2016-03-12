using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(22);
            myList.Add(333);
            string result = myList.ListToString();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

namespace ExtensionMethod
{
    static class MyClass
    {
        public static string ListToString(this IList iList)
        {
            string result = "";
            for (int i = 0; i < iList.Count; i++)
                result = result + iList[i].ToString() + ", ";
            return result;
        }
    }
}