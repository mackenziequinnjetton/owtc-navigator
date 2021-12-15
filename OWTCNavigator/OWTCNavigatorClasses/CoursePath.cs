using System;
using System.Collections.Generic;

namespace OWTCNavigatorClasses
{
    public class CoursePath
    {
        public List<string> CourseList { get; set; }

        public CoursePath(List<string> courseList)
        {
            CourseList = courseList;
        }
    }
}
