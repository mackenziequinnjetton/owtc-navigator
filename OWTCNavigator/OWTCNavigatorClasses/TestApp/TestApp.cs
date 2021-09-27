using System;
using OWTCNavigatorClasses;
using System.IO;
using System.Collections.Generic;

namespace TestApp
{
    class TestApp
    {
        static void Main(string[] args)
        {
            /*var testSchedule = new Schedule(new int[] { 6, 6, 6, 6, 6, 0, 0 });

            var myDueDate = new ModuleDueDates(testSchedule);*/

            // Test file path: C:\Users\macke\OneDrive\Otech\PROG1060\Database Files\Software Technology\Structured Project II.csv

            // Note: input validation will be ignored, as this is only a test
            // app with limited functionality. The full release will have it.

            List<Module> moduleList = new List<Module>();

            Console.WriteLine("Please enter a file path to retrieve " +
                "course data from.");
            var filePath = @$"{Console.ReadLine()}";

            while (true)
            {
                if (File.Exists(filePath))
                {
                    moduleList = CourseFileProcessor
                        .ProcessCourseModules(filePath);
                    break;
                }
                else
                {
                    Console.WriteLine("No file exists at that path.");
                    Console.WriteLine("Please enter a file path to " +
                        "retrieve course data from.");
                    filePath = @$"{Console.ReadLine()}";
                    continue;
                }
            }

            List<int> scheduleList = new List<int>();

            var dayArray = new string[] {"Mondays", "Tuesdays", "Wednesdays",
                "Thursdays", "Fridays"};

            scheduleList.Add(0);
            foreach (var day in dayArray)
            {
                Console.WriteLine("Please enter your number of hours " +
                $"enrolled on {day}.");
                scheduleList.Add(int.Parse(Console.ReadLine()));
            }
            scheduleList.Add(0);

            var studentSchedule = new Schedule(scheduleList);

            Console.WriteLine("Please enter your course's start date.");
            DateTime.TryParse(Console.ReadLine(), out DateTime startDate);

            var dueDates = GenerateModuleDueDates.Generate(studentSchedule,
                startDate, moduleList);

            Console.WriteLine("\nMODULE DUE DATES");
            foreach (var dueDate in dueDates)
            {
                Console.WriteLine($"{dueDate.Name,-80}{dueDate.GetFormattedDueDate()}");
            }
        }
    }
}
