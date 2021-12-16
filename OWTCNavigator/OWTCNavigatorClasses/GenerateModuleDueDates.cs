using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OWTCNavigatorClasses
{
    public static class GenerateModuleDueDates
    {
        // Generates module due dates,
        // taking into account the number of hours a student is enrolled
        // per day, as well as weekends and holidays
        public static List<ModuleDueDate> Generate(Schedule studentSchedule, 
            DateTime startDate, List<Module> moduleList)
        {
            var hoursLeftInDay = 0;
            var moduleDueDateList = new List<ModuleDueDate>();
            
            // Keeps track of the day the algorithm is on in the process
            // of generating future due dates, starting from the user supplied
            // course start date
            var currentDay = startDate;

            foreach (var module in moduleList)
            {
                var remainingModuleHours = module.Hours;

                // The below if...else... statements cover various 
                // cases where the starting day for a module is a holiday,
                // or where the amount of hours left in the current day
                // are already enough to finish the module, or where there
                // are still hours left in the current day but not enough to
                // finish the module

                // If none of these cases are true, the algorithm continues
                // with the while loop

                if (Holiday.IsHoliday(currentDay))
                {
                    currentDay = currentDay.AddDays(1);
                }
                
                // If there are more hours left in the day than are needed
                // to complete the module, add a new due date for the current
                // day and current module to the due date list, subtract the 
                // previously remaining number of module hours from the hours
                // left in the day, set the remaining module hours to 0,
                // and continue on to the next module
                else if (hoursLeftInDay > remainingModuleHours)
                {
                    moduleDueDateList.Add(new ModuleDueDate(module.Name,
                        currentDay));
                    hoursLeftInDay -= remainingModuleHours;
                    remainingModuleHours = 0;
                    continue;
                }

                // If there are an equal number of hours left in the day 
                // as are remaining in the module, add a new due date for 
                // the current day and current module to the due date list,
                // subtract the previously remaining number of module hours
                // from the hours left in the day, set the remaining module
                // hours to 0, move to the next day, and continue to the
                // next module
                else if (hoursLeftInDay == remainingModuleHours)
                {
                    moduleDueDateList.Add(new ModuleDueDate(module.Name,
                        currentDay));
                    hoursLeftInDay -= remainingModuleHours;
                    remainingModuleHours = 0;
                    currentDay = currentDay.AddDays(1);
                    continue;
                }

                // If there are less hours left in the day than are needed
                // to complete the module, subtract the hours left in the day
                // from the remaining module hours, set the hours left in the
                // day to 0, and move to the next day
                else if (hoursLeftInDay != 0)
                {
                    remainingModuleHours -= hoursLeftInDay;
                    hoursLeftInDay = 0;
                    currentDay = currentDay.AddDays(1);
                }

                // The algorithm's logic in the while loop is similar to the
                // above if...else statements. See the comments there for
                // details on the logic involved
                while (true)
                {
                    // Query the student's schedule for the number of school
                    // hours they're scheduled for on the working day
                    var currentDayScheduledHours = studentSchedule
                        .ScheduleList[(int)currentDay.DayOfWeek];

                    if (Holiday.IsHoliday(currentDay))
                    {
                        currentDay = currentDay.AddDays(1);
                        continue;
                    }
                    else if (remainingModuleHours >= currentDayScheduledHours)
                    {
                        remainingModuleHours -= currentDayScheduledHours;
                        if (remainingModuleHours == 0)
                        {
                            moduleDueDateList.Add(new ModuleDueDate(
                                module.Name, currentDay));
                            break;
                        }
                        currentDay = currentDay.AddDays(1);
                        continue;

                    }
                    else if (remainingModuleHours != 0)
                    {
                        hoursLeftInDay = (currentDayScheduledHours
                            - remainingModuleHours);
                        remainingModuleHours = 0;
                        moduleDueDateList.Add(new ModuleDueDate(
                            module.Name, currentDay));
                        break;
                    }
                    else
                    {
                        hoursLeftInDay = 0;
                        moduleDueDateList.Add(new ModuleDueDate(
                            module.Name, currentDay));
                        break;
                    }
                }
            }

            return moduleDueDateList;
            
            /*try
            {
                var builder = new SqlConnectionStringBuilder();

                builder.DataSource = "localhost.SoftwareDevelopment.windows.net";
                builder.InitialCatalog = "SoftwareDevelopment";

                using (var connection = new SqlConnection("Data Source = DESKTOP - AFB519I; Initial Catalog = SoftwareTechnology; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"));
                {
                    
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }
    }
}
