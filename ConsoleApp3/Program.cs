using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            library library = new library();
            Console.WriteLine("введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите действие");
            string variable = Console.ReadLine();
            library.Calculator(a,b,variable);
        }
    }
}
