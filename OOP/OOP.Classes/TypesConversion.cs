using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    public class TypesConversion
    {

        public void Test()
        {

            Console.WriteLine(10);
            Console.WriteLine("sdfsdf");
            int i = 19;
            long j = i; // Implicit Conversion
            int k = (int)j; // Explicit conversion
            long l = long.MaxValue;
            
            int ll = (int)l;
            string str = "234234";
            int st1 = Convert.ToInt32(str);

            string str2 = "sdfsdfsdf";
            int st2 = Convert.ToInt32(str2);

            object o = long.MaxValue;
            int kk = (int)o;
        }
    }
}
