using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OWTCNavigatorClasses
{
    public static class CourseFileProcessor
    {
        // For testing purposes, opens a CSV file with sample course
        // information, and parses it into a list of modules
        public static List<Module> ProcessCourseModules(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            var moduleList = new List<Module>();

            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                // Adds only the module name and the number of progress hours
                moduleList.Add(new Module(values[3], float.Parse(values[5])));
            }

            return moduleList;
        }
    }
}
