using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWTCNavigatorClasses
{
    public class Module
    {
        public string Name { get; set; }
        public int Hours { get; set; }

        public Module(string name, float hours)
        {
            Name = name;
            Hours = (int)hours;
        }
    }
}
