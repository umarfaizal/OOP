using System;
using OOP.Development;

namespace OOP.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            DeveloperBase developerBase = new DeveloperBase();

            Console.WriteLine("Hello World!");
            //Calculator.ProjectType = "";
            Calculator.TestStatic = "";
            Calculator calculator = new Calculator();
            
            var sty = Calculator.ReadonlyStatic;
            //Calculator.ReadonlyStatic = ""
            //Calculator.
            var addition = calculator.Add(4, 5);
            var subtraction = calculator.Sub(5, 2);

            AdvanceCalculator advanceCalculator = new AdvanceCalculator();
            var mul = advanceCalculator.AdvMultiply();
        }
    }

    public class Calculator
    {

        public const string ProjectType = "ProjectType";
        public static string TestStatic = "Test";
        public string Description = "It is used to do calculation";
        public readonly static string ReadonlyStatic;
        public string ClassName;
        static Calculator()
        {
            ReadonlyStatic = "ReadonlyStatic";
        }
        public Calculator()
        {
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
}
