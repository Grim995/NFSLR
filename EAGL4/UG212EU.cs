using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFSLR.Core;

namespace NFSLR.EAGL4
{
    public sealed class UG212EU : UG2
    {
        public UG212EU()
        {

        }

        public override bool Init(GameProcess process)
        {
            addr = 0x00863774;
            return base.Init(process);
        }
    }
}
