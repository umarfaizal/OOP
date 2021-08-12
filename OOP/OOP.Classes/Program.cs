using System;
using OOP.Development;
using OOP.Sample;

namespace OOP.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            #region sdfsdf

           //
           //
           //

            #endregion
            //DeveloperBase developerBase = new DeveloperBase();
            //Console.WriteLine(developerBase.Skill);
            //developerBase.Team = "dfsdf";
            Console.WriteLine("Hello World!");
            //Calculator.ProjectType = "";
            //Calculator.TestStatic = "";
            //var sty = Calculator.ReadonlyStatic;
            //Calculator calculator = new Calculator();
            //Calculator calculator2 = new Calculator();
            //Calculator calculator3 = new Calculator();
            //Calculator calculator4 = new Calculator();
            //Calculator calculator5 = new Calculator();
            //Calculator.ReadonlyStatic = ""
            //Calculator.
            //var addition = calculator.Add(4, 5);
            //var subtraction = calculator.Sub(5, 2);

            //AdvanceCalculator advanceCalculator = new AdvanceCalculator();
            //var mul = advanceCalculator.AdvMultiply();
            //var a = calculator.Add(8, 9);
            //var b = calculator.Add(5, 7, 1);
            //var c = calculator.Add(3, 33, 2);
            //var d = calculator.Add(2, 33, 12, 8);
            //calculator.MyProperty = 5;
            //calculator.Name = "Vignesh";
            //Console.WriteLine(calculator.Name);
            //calculator.Name = "Kumar";
            //Console.WriteLine(calculator.Name);

            //Student st = new Student();
            //Student st2 = new Student(2);
            //Student st3 = new Student("Vignesh");
            //Student st4 = new Student(3, "kumar");
            //Student st5 = new Student(6, "Arun", 890);
            //Student st6 = new Student(23, "Ramesh", 457, "Bangalore");

            //OverrideBase1 overrideBase1 = new OverrideBase1();
            //var base1 = overrideBase1.GetString();

            //OverrideBase2 overrideBase2 = new OverrideBase2();
            //var base2 = overrideBase2.GetString();

            //OverrideBase3 overrideBase3 = new OverrideBase3();
            //var base3 = overrideBase3.GetString();

            //OverrideBase4 overrideBase4 = new OverrideBase4();
            //var base4 = overrideBase4.GetString();
            //st6.Id = 789;

            //PartialClass partialClass = new PartialClass();
            //partialClass.Address = "";
            //partialClass.Mobile = "";
            //partialClass.Name = "";

            //TypesConversion typesConversion = new TypesConversion();
            //typesConversion.Test();

            //CopyConstrcutor a = new CopyConstrcutor();
            //a.Id = 19;
            //a.Name = "sdfsdf";
            //CopyConstrcutor b = new CopyConstrcutor(a);

            //Console.WriteLine(b.Id);
            //Console.WriteLine(b.Name);

            //ValidateInterface validateInterface = new ValidateInterface();
            //validateInterface.Test();

            //ValidateException validateException = new ValidateException();
            //validateException.Test();
            LoopSample loopSample = new LoopSample();
            loopSample.DoWhile();
            loopSample.While();
        }
    }

    public class Calculator
    {

        public const string ProjectType = "ProjectType";
        public static string TestStatic = "Test";
        public string Description = "It is used to do calculation";
        public readonly static string ReadonlyStatic;
        public readonly string ReadonlyProps;
        public string ClassName;

        public int MyProperty { get; set; }
        private string _name;
        public string Name
        {
            get
            {
                return _name + " is a person";
            }
            set
            {
                if (value == "Vignesh")
                {
                    Console.WriteLine(value + " is known person");
                }
                _name = value;
            }
        }
        static Calculator()
        {
            ReadonlyStatic = "ReadonlyStatic";

        }
        public Calculator()
        {
            //ReadonlyStatic = "sdfsdfsdf";
            IsClassInit = true;
            ClassName = "Calculator";

        }
        public bool IsClassInit { get; set; }
        public int Add(int a, int b)
        {
            ClassName = "new Class Name";
            int c = a + b;
            return c;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        public int Add(int a, int b, int c, int d, int e)
        {
            return a + b + c + d + e;
        }

        public int Sub(int a, int b)
        {

            return a - b;
        }

        protected int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class AdvanceCalculator : Calculator
    {
        public int AdvMultiply()
        {
            return Multiply(4, 5);
        }
    }


    public class Student : BaseContructor
    {

        public Student() : base("")
        {

        }
        public Student(string name): base(name)
        {
            //this.Name = name;
        }
        public Student(int id) : base("")
        {
            this.Id = id;
        }

        public Student(int id, string name) : base(name)
        {
            this.Id = id;
            //this.Name = name;
        }

        public Student(int id, string name, int mobile) : this(id, name)
        {
            //this.Id = id;
            //this.Name = name;
            this.Mobile = mobile;
        }

        public Student(int id, string name, int mobile, string address) : this(id,name, mobile)
        {
            //this.Id = id;
            //this.Name = name;
            //this.Mobile = mobile;
            this.Address = address;
        }


        public readonly int Id; 
        //public string Name { get; set; }

        public int Mobile { get; set; }
        public string Address { get; set; }

    }


    public class BaseContructor
    {
        public BaseContructor(string name222)
        {
            this.Name = name222;
        }

        public readonly string Name;
    }

    public class OverrideBase1
    {

        public virtual string GetString()
        {
            return "OverrideBase1:::";
        }
    }

    public class OverrideBase2 : OverrideBase1
    {
        public override string GetString()
        {
            var baseValue = base.GetString();
            return "OverrideBase2:::";
        }
    }

   
    public class OverrideBase3 : OverrideBase1
    {
        public override string GetString()
        {
            var baseValue = base.GetString();
            return baseValue + "OverrideBase3:::";
        }
    }
   
    public class OverrideBase4 : OverrideBase1
    {
        public sealed override string GetString()
        {
            var baseValue = base.GetString();
            return baseValue + "OverrideBase4:::";
        }
    }

    public class OverrideBase5 : OverrideBase3
    {
        public override string GetString()
        {
            var baseValue = base.GetString();
            return "OverrideBase5:::";
        }
    }

    //public class OverrideBase6 : OverrideBase4
    //{
    //    public override string GetString()
    //    {
    //        var baseValue = base.GetString();
    //        return baseValue + "OverrideBase6:::";
    //    }
    //}

}
