using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class TestVariable
    {
        public int Add(int a,int b)
        {
            a = a + b;
            return a;
        }

        public string AddStr(string str)
        {
            str = str + DateTime.Now.ToString();

            return str;
        }

        public string UpdateStringBuilder(StringBuilder sb)
        {
            sb.Append(DateTime.Now.ToString());

            return sb.ToString ();
        }

        public string UpdateClassA(TestA a)
        {
            a.i = 2;
            a.Name = "B";

            return a.ToString();
        }
    }

    class TestA
    {
        public int i;
        public string Name;

        public TestA()
        {
            i = 1;
            Name = "A";
        }

        public string ToString()
        {
            return i.ToString() + Name;
        }
    }
}
