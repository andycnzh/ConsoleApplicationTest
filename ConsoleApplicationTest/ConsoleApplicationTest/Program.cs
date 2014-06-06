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
            Console.WriteLine("------");

            Console.WriteLine(DateTime.Now.ToString("yyyyMMddHHmmss"));
            Console.WriteLine(Guid.NewGuid().ToString ().Replace('-',' '));

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

            Console.ReadLine();
        }
    }
}
