using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OWTCNavigatorClasses
{
    public static class ValidateStudentID
    {
        // Checks if student ID passed as argument is in the right format
        // (10 digits exactly, nothing else)
        public static bool Validate(string studentID)
        {
            var studentIDRegex = new Regex(@"^\d{10}$");
            
            return studentIDRegex.IsMatch(studentID);
        }
    }
}
