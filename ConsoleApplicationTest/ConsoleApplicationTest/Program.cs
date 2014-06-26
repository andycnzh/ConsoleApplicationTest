using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("------");

            //Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
            //Console.WriteLine(Guid.NewGuid().ToString ().Replace('-',' '));

            //Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff") + (new Random(1000)).Next());
            //Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            //Console.WriteLine("------");
            //Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
            //Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            //Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff") + (new Random(1000)).Next());
            //Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            //Console.WriteLine("------");
            //Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmssfff") + (new Random(1000)).Next());
            //Console.WriteLine(Guid.NewGuid().ToString().Replace('-', ' '));
            //Console.WriteLine("------");
            //Console.WriteLine(DateTime.Now.Ticks.ToString());

            //Console.ReadLine();

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
            Console.WriteLine(sb.ToString ());

            TestA myA = new TestA();
            myA.i = 3;
            myA.Name = "C";
            Console.WriteLine(myA.ToString());
            tv.UpdateClassA(myA);
            Console.WriteLine(myA.ToString());

            Console.ReadLine();
        }
    }
}
