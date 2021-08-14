using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Sample
{
    public class StudentSample
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentSample()
        {

        }

        public StudentSample(string name)
        {
            this.Name = name;
        }

        public static bool operator ==(StudentSample a, StudentSample b)
        {
            if (a.Id == b.Id && a.Name == b.Name && a.Name != "Vignesh")
            {
                return true;
            }
            else return false;
        }

        public static bool operator !=(StudentSample a, StudentSample b)
        {
            return !(a == b);
        }
        
        public static implicit operator string(StudentSample a)
        {
            return a.Name;
        }
        public static explicit operator StudentSample(string name)
        {
            return new StudentSample(name);
        }
    }
}
