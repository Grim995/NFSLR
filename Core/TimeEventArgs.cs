using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR.Core
{
    public class TimeEventArgs
    {
        public long TimePassed
        {
            get; private set;
        }

        public bool CountIn
        {
            get; set;
        }

        public TimeEventArgs(long ms)
        {
            TimePassed = ms;
            CountIn = true;
        }
    }
}
