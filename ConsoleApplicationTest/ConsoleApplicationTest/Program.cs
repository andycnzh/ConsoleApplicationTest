using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // output the menu
            // accept user input
            // execute the selected menu
            // clean the screen output
            // start over again

            MenuHanlder();

            Console.ReadLine();
        }

        private static void MenuHanlder()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Console Application Test");
                Console.WriteLine("1. DateTime format test");
                Console.WriteLine("2. Variable test");
                Console.WriteLine("3. Math Double test");
                Console.WriteLine("4. Log test");
                Console.WriteLine("5. FilePath test");
                Console.WriteLine("6. Exception test");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        DateTimeFormatTest();
                        break;
                    case "2":
                        TestVariableTest();
                        break;
                    case "3":
                        DoubleTest();
                        break;
                    case "4":
                        LogTest();
                        break;
                    case "5":
                        FilePathTest();
                        break;
                    case "6":
                        ExceptionTest();
                        break;
                    case "exit":
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Catch one exception: {0}", ex.Message));
            }

            Console.ReadLine();

            MenuHanlder();
        }

        private static void ExceptionTest()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Catch one exception: {0}", ex.Message));
                throw ex;
            }

        }

        private static void FilePathTest()
        {

            string filePath = @"d:\Code\TFS_Projects\QSTeam\EWSJSAutomation\Microsoft.Support.UnifiedDesktop.Library.Automations.JSInjection\Steps\JsInjectionSteps.cs";

            Console.WriteLine(FilePathRoute.GetPartFromFilePath(filePath, RouteType.FileName));
            Console.WriteLine(FilePathRoute.GetPartFromFilePath(filePath, RouteType.FileSuffix));
            Console.WriteLine(FilePathRoute.GetPartFromFilePath(filePath, RouteType.NameOnly));
            Console.WriteLine(FilePathRoute.GetPartFromFilePath(filePath, RouteType.PathExceptName));
            Console.WriteLine(FilePathRoute.GetPartFromFilePath(filePath, RouteType.PathExceptSuffix));

        }

        private static void LogTest()
        {
            MyLog mylog = new MyLog();
            mylog.Log("hello world");

            mylog.Log("hello china");
        }

        private static void DoubleTest()
        {
            string doubleMax = double.MaxValue.ToString();
            Console.WriteLine(doubleMax);

            Regex regex = new Regex(@"(\d*.\d*)E([+ -]?\d*)");
            string p = regex.Replace(doubleMax, "$1");
            Console.WriteLine(p);

            p = Convert.ToString((double.Parse(p) + 0.1));
            Console.WriteLine(p);

            Console.WriteLine(regex.Replace(doubleMax, "$2"));

            doubleMax = p + "E" + regex.Replace(doubleMax, "$2");

            try
            {
                Console.WriteLine(double.Parse(doubleMax));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("---");
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine("---");

            try
            {
                Console.WriteLine(double.Parse(decimal.MaxValue.ToString()));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("===");

            string doubleMax1 = (double.MaxValue + long.MaxValue).ToString();
            Console.WriteLine(doubleMax1);



            string doubleMin = double.MinValue.ToString();
            Console.WriteLine(doubleMin);

            string longMax = long.MaxValue.ToString();
            Console.WriteLine(longMax);
        }

        private static void TestVariableTest()
        {
            TestVariable tv = new TestVariable();

            int a = 1;
            int b = 2;
            Console.WriteLine(a);
            tv.Add(a, b);
            Console.WriteLine(a);

            string str = "abcdefg";
            Console.WriteLine(str);
            tv.AddStr(str);
            Console.WriteLine(str);

            StringBuilder sb = new StringBuilder("123456");
            Console.WriteLine(sb.ToString());
            tv.UpdateStringBuilder(sb);
            Console.WriteLine(sb.ToString());

            TestA myA = new TestA();
            myA.i = 3;
            myA.Name = "C";
            Console.WriteLine(myA.ToString());
            tv.UpdateClassA(myA);
            Console.WriteLine(myA.ToString());

            Console.WriteLine(tv.UpdateClassB(myA));
            Console.WriteLine(myA.ToString());

            Console.WriteLine(tv.UpdateClassC(ref myA));
            Console.WriteLine(myA.ToString());
        }

        private static void DateTimeFormatTest()
        {
            Console.WriteLine("------");

            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
            Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));

            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff") + (new Random(1000)).Next());
            Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            Console.WriteLine("------");
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
            Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff") + (new Random(1000)).Next());
            Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            Console.WriteLine("------");
            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff") + (new Random(1000)).Next());
            Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            Console.WriteLine("------");
            Console.WriteLine(DateTime.Now.Ticks.ToString());
        }

    }
}
