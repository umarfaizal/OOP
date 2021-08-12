using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Sample
{
   public class LoopSample
    {
        public void DoWhile()
        {
            // Do While code block will call atleast one time in the execution , after that only it will check the condition
            int i = 10;
            do
            {
                Console.WriteLine("Do While Calling");
                i++;
            } while (i < 10);
        }
        public void While()
        {
            int i = 10;
            // while loop first check condition before executing code block , if it true then only code block will execute.
            while (i < 10)
            {
                Console.WriteLine("While Calling");
                i++;
            } 
        }
    }
}
