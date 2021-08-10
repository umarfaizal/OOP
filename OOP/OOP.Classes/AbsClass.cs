using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    public abstract class AbsClass
    {
        
        public AbsClass(int i)
        {
            this.MyProperty = i;
        }
        public int MyProperty { get; set; }

        public abstract void Test();
       

        public virtual string Test2()
        {
            return "";
        }

        public  string Test3()
        {
            return "";
        }
    }

    public class AbsDerived : AbsClass
    {
        public AbsDerived() :base(8)
        {

        }
        public override void Test()
        {
            
        }
    }
}
