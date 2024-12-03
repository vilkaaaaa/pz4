using Xunit;
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Tests
{
    public class libraryTests
    {
        [Fact()]
        public void StringiTest()
        {
           library library = new library();
            string myString = "радар";
            bool res = true;
            bool actualres = library.Stringi(myString);
            Assert.Equal(res, actualres);
        }

        [Fact()]
        public void YearVesTest()
        {
            library library = new library();
            int year = 2000;
            bool res = true;
            bool actualres = library.YearVes(year);
            Assert.Equal(res, actualres);
        }

        [Fact()]
        public void CalculatorTest()
        {
            library library  = new library();
            string variable = "+";
            string variable1 = "/";
            int a = 5;
            int b = 0;
            int res = 13;
            //int r = 0;
            //Action action = () => { library.Calculator(a, r, variable1); };
            int actualres = library.Calculator(a,b, variable);
            int actualres2 = library.Calculator(a,b,variable1);
            //Exception ex = new Exception("ошибка деления, введите значение отличное от 0");
            //Assert.Throws(ex.GetType(), action);
            Assert.Throws<DivideByZeroException>(() =>
            {
                int result = a/ 0;
            });

            Assert.Equal(res, actualres);
        }
    }
}