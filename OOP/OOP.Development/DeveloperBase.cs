using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Development
{
    public class DeveloperBase
    {
       
        public DeveloperBase()
        {

        }
        public int EmpId { get; set; }
        private string ClassName = "DeveloperBase";
        protected string Address { get; set; }
        internal string Mobile { get; set; }
        protected internal string Name { get; set; }
    }

    public class AE : DeveloperBase
    {
       public void Test()
        {
            // EmpId
            // Address
            // Mobile
            // Name
        }
    }
}
