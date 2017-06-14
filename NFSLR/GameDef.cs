using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR
{
    using Core;
    public class GameDef : Options
    {
        [Property]
        public string Name
        {
            get; set;
        }

        [Property]
        public string Classpath
        {
            get; set;
        }

        [Property]
        public string Module
        {
            get; set;
        }

        [Property]
        public string Dll
        {
            get; set;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
