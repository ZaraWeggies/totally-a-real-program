using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProgram.src.Entities
{
    internal class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Job? Job { get; set; }
        public Gender? Gender { get; set; }

        public bool IsOldEnoughToWork()
        {
            return Age >= 16;
        }

        public bool IsOldEnoughToRetire()
        {
            return Age >= 65;
        }
    }
}
