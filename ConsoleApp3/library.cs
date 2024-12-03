using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class library
    {
        public bool Stringi(string myString)
        {
            string first = myString.Substring(0, myString.Length);
            char[] arr = myString.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length);
            Console.WriteLine(second);
            if (first.Equals(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool YearVes(int a)
        {
            if (a % 100 != 0 && a % 4 == 0 || a % 400 == 0)
            {
                Console.WriteLine("високосный");
                return true;
            }
            else
            {
                Console.WriteLine("не високосный");
                return false;
            }
        }

        public int Calculator(int a, int b, string variable)
        {
            int res;
            switch (variable)
            {
                case "+":
                    res = a + b;
                    Console.WriteLine(res);
                   return res;                

                case "-":
                    res = a - b;
                    Console.WriteLine(res); return res;

                case "*":
                    res = a * b;
                    Console.WriteLine(res); return res;

                case "/":
                    if (b == 0)
                    {
                       throw new Exception("ошибка деления, введите значение отличное от 0");
                    }
                    else
                    {
                        res = a / b; Console.WriteLine(res); return res;
                    }
              
            }
      
            return a;
        }

    }
}
