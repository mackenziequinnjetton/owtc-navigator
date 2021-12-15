using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWTCNavigatorClasses
{
    public class ModuleDueDate
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }

        public ModuleDueDate(string name, DateTime dueDate)
        {
            Name = name;
            DueDate = dueDate;
        }

        public string GetFormattedDueDate()
        {
            return DueDate.ToLongDateString();
        }
    }
}
