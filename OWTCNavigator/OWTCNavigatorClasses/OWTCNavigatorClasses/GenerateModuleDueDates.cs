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
        public static List<ModuleDueDate> Generate(Schedule studentSchedule, 
            DateTime startDate, List<Module> moduleList)
        {
            var hoursLeftInDay = 0;
            var moduleDueDateList = new List<ModuleDueDate>();
            var currentDay = DateTime.Today;

            foreach (var module in moduleList)
            {
                var remainingModuleHours = module.Hours;

                if (hoursLeftInDay > remainingModuleHours)
                {
                    moduleDueDateList.Add(new ModuleDueDate(module.Name,
                        currentDay));
                    hoursLeftInDay -= remainingModuleHours;
                    remainingModuleHours = 0;
                    continue;
                }
                else if (hoursLeftInDay == remainingModuleHours)
                {
                    moduleDueDateList.Add(new ModuleDueDate(module.Name,
                        currentDay));
                    hoursLeftInDay -= remainingModuleHours;
                    remainingModuleHours = 0;
                    currentDay += new TimeSpan(1, 0, 0, 0);
                    continue;
                }
                else if (hoursLeftInDay != 0)
                {
                    remainingModuleHours -= hoursLeftInDay;
                    hoursLeftInDay = 0;
                    currentDay += new TimeSpan(1, 0, 0, 0);
                }

                while (true)
                {
                    var currentDayScheduledHours = studentSchedule
                        .ScheduleList[(int)currentDay.DayOfWeek];

                    if (remainingModuleHours >= currentDayScheduledHours)
                    {
                        remainingModuleHours -= currentDayScheduledHours;
                        if (remainingModuleHours == 0)
                        {
                            moduleDueDateList.Add(new ModuleDueDate(
                                module.Name, currentDay));
                            break;
                        }
                        currentDay += new TimeSpan(1, 0, 0, 0);
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
