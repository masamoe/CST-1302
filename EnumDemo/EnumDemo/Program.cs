//#define MY_DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    class Program
    {

        static void Main(string[] args)
        {
            //TestClass.TestMethod();

#if (MY_DEBUG)
            {
                TestClass test = new TestClass();
                test.TestMethod();

                int sunday = (int)Days.Sunday;
                Console.WriteLine(sunday);
            }
#endif

            int sat = (int)Days.Saturday;
            Console.WriteLine(sat);

            //Program objectName = new Program();
            //objectName.TestMethod();

            TestMethod();


            Console.ReadKey();
        }

        public static void TestMethod()
        {
            int wes = (int)Days.Wednesday;
            Console.WriteLine(wes);
        }
    }
}