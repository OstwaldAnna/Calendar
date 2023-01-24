using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Holiday
    {
        public string Name;
        public DateTime Date;

        public Holiday(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }
    }
}
