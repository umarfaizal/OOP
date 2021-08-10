using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes
{
    public class CopyConstrcutor
    {
        #region Copy Constructor

        public CopyConstrcutor(CopyConstrcutor obj)
        {
            this.Name = obj.Name;
            this.Id = obj.Id;
        }
        #endregion
        #region Instance Constructor

        //instance Constructor
        public CopyConstrcutor()
        {

        }
        //instance Constructor - Overload
        public CopyConstrcutor(string name)
        {
            this.Name = name;
        }

        //instance Constructor - Overload
        public CopyConstrcutor(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
#endregion

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
