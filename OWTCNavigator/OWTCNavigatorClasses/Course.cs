using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWTCNavigatorClasses
{
    public class Course
    {
        public string CourseName { get; set; }
        public int ProgressHours { get; set; }
        public DateTime StartDate { get; set; }

        public Course(string courseName, int progressHours, 
            DateTime startDate)
        {
            CourseName = courseName;
            ProgressHours = progressHours;
            StartDate = startDate;
        }
    }
}
