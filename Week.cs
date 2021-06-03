using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class Week
    {
        public readonly string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satuday", "Sunday" };
        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
}
