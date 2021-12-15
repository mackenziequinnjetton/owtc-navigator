using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWTCNavigatorClasses
{
    public class Schedule
    {
        private List<int> scheduleList;

        public Schedule(List<int> scheduleList)
        {
            ScheduleList = scheduleList;
        }

        public List<int> ScheduleList
        {
            get
            {
                return scheduleList;
            }
            set
            {
                scheduleList = value;
            }
        }
    }
}
