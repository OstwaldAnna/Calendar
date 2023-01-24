using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Reminder
    {
        public string Name;
        public DateTime Date;

        public Reminder(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}
