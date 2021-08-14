using OOP.Sample;

namespace OOP.Classes
{
    #region Access Modifier
    public class PrivateProtectedValidate : PrivateProtectedBase
    {
        public void Test()
        {
            // we can't access Private protected field outside of assembly even we inherit the class
             // this.Id = 140;
        }
    }
    #endregion
}
