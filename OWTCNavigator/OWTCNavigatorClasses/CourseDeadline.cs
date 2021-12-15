using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWTCNavigatorClasses
{
    public class CourseDeadline
    {
        private DateTime deadline;

        public CourseDeadline(DateTime deadline)
        {
            Deadline = deadline;
        }

        public DateTime Deadline
        {
            get
            {
                return deadline;
            }
            set
            {
                // Time and a half of course starting date plus progress hours
            }
        }
    }
}
