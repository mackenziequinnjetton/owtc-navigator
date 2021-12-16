using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OWTCNavigatorClasses
{
    class ModuleDueDates
    {
        public DateTime[] dueDates { get; set; }

        public ModuleDueDates(Schedule studentSchedule)
        {
            GenerateDueDates(studentSchedule);
        }

        public void GenerateDueDates(Schedule studentSchedule)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            }
        }
    }
}
