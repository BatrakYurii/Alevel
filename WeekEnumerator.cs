using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    public class WeekEnumerator
    {
        public class WeekEnumerator : IEnumerator
        {
            private int _current = -1;
            public string[] days;
            public WeekEnumerator(string[] days)
            {
                this.days = days;
            }

            public object Current
            {
                get
                {
                    if (_current == -1 || _current > days.Length)
                    {
                        throw new Exception();
                    }

                    return days[_current];
                }
            }

            public bool MoveNext()
            {
                if (_current < days.Length - 1)
                {
                    _current++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                if (_current == days.Length - 1)
                {
                    _current = -1;
                }
            }
        }
    }
}
