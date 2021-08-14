using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Sample
{

    #region Protected Internal
    /// <summary>
    /// Protected internal :: Can access same assembly via inherit or instance
    /// Protected internal :: Can inherit outside the assembly, but fields and methods can access only on the inherit class. We can't access using instance
    /// </summary>
    public class ProtectedInternalBase
    {
        protected internal int Id ;
    }

    public class ProtectedInternalAccess
    {
        public void Test()
        {
            var obj = new ProtectedInternalBase();
            obj.Id = 5;
        }
    }

    public class ProtectedInternalDerived : ProtectedInternalBase
    {
        public void Test()
        {
            this.Id = 100;
        }
    }
    #endregion

    #region Private Protected
    /// <summary>
    /// Protected internal :: Can access same assembly via inherit or instance
    /// Protected internal :: Can inherit outside the assembly, but fields and methods can access only on the inherit class. We can't access using instance
    /// </summary>
    public class PrivateProtectedBase
    {
        private protected int Id = 0;
    }

    public class PrivateProtectedAccess
    {
        public void Test()
        {
            var obj = new PrivateProtectedBase();
            // We can't access private protected field using instance of class even its same assembly
            // obj.Id = 5;
        }
    }

    public class PrivateProtectedDerived : PrivateProtectedBase
    {
        public void Test()
        {
            // we can access private protected field when we inherit to another class in the same Assembly
            this.Id = 100;
        }
    }
    #endregion
}
