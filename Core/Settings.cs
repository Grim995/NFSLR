using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR.Core
{
    public class Settings : Options
    {
        [Property]
        public int BkColor
        {
            get; set;
        }

        [Property]
        public int TColor
        {
            get; set;
        }

        [Property]
        public int StarHKey
        {
            get; set;
        }

        [Property]
        public int StopHKey
        {
            get; set;
        }

        [Property]
        public int ResetHKey
        {
            get; set;
        }
    }
}
