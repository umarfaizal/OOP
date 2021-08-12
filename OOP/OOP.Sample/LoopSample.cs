using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Sample
{
   public class LoopSample
    {
        public void DoWhile()
        {
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
            while (i < 10)
            {
                Console.WriteLine("While Calling");
                i++;
            } 
        }
    }
}
