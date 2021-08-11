using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Sample
{
    public class ExceptionSample
    {
        public void DefaultException()
        {
            try
            {
                string input = Console.ReadLine();
                int i = Convert.ToInt32(input);
            }
            catch (Exception e)
            {
                // Catching the error
                Console.WriteLine("DefaultException::Catch::" + e.Message);
            }
            finally
            {
                // statements should excute after try or catch complete . 
                // this block forcibly call even exception also
                // Finally block is not mandatory
                // it is mostly used to dispose object like DB connection
                Console.WriteLine("Finally blocks always Calling");
            }
        }

        public void DivideException(int a, int b)
        {
            int ouput = 0;
            try
            {
                ouput = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideException::Catch::" + e.Message);
            }
            finally
            {
                Console.WriteLine("DivideException::Result::" + ouput);
            }
        }

        public void ThrowExceptionValidate(string name)
        {
            if(name  == "vignesh")
            {
               
                //throw new HomeException(name + " is not valid", 12);
                var st = new HomeException(name + " is not valid", 12);
                throw st;
            }
            else if(name == "kumar")
            {
                throw new Exception("Default exception is firing");
            }
            else
            {
                Console.WriteLine("User is valid");
            }
        }
        public void ThrowException()
        {
            try
            {
                ThrowExceptionValidate("kumar");
            }
           
            catch (HomeException e)
            {

                Console.WriteLine($"Message::{e.Message}::ErrorCode::{e.MyErrorCode}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Message::{e.Message}");
            }
        }
    }

    public class HomeException  : System.Exception
    {
        public HomeException(string message, int myErrorCode) : base(message)
        {
            this.MyErrorCode = myErrorCode;
        }

        public int MyErrorCode { get; set; }
    }

    public class ValidateException
    {
        public void Test()
        {
            ExceptionSample exceptionSample = new ExceptionSample();
            //exceptionSample.DefaultException();
            //exceptionSample.DivideException(25, 0);
            exceptionSample.ThrowException();
        }
    }
}
