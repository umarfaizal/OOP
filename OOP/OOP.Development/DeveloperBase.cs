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
        public void SetSkill(string skill)
        {
            this.Skill = skill;
        }
        public int EmpId { get; set; }
        private string ClassName = "DeveloperBase";
        protected string Address { get; set; }
        internal string Mobile { get; set; }
        protected internal string Name { get; set; }

        private string _skill;
        public string Skill
        {
            get
            {
                return _skill;
            }
            private set
            {
                _skill = value;
            }
        }

        private string _team;
        public string Team
        {
            get
            {
                return _team;
            }
            protected internal set
            {
                _team = value;
            }
        }
    }

    public class AE  // : DeveloperBase
    {
        public void Test()
        {

            DeveloperBase dev = new DeveloperBase();
            dev.Team = "adfsdf";
            //base.EmpId;
            // Address
            // Mobile
            // Name
            //dev.Team = "sdfsdf";
            //base.Team = "sdfdsf";
        }
    }
}
