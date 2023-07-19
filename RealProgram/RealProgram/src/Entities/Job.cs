using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProgram.src.Entities
{
    internal class Job
    {
        public string? Title { get; set; }
        public string? Location { get; set; }
        public int Salary { get; set; }
        public int YearsExperience { get; set; }

        public bool IsWellPaid()
        {
            return Salary > 100000;
        }

        public bool IsSenior()
        {
            return YearsExperience > 10;
        }

        public bool IsRemote()
        {
            return Location == "Remote";
        }
    }
}
