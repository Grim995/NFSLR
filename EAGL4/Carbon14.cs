using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR.EAGL4
{
    using Core;
    public class Carbon14 : IGame
    {
        GameProcess proc;
        bool isLoading;

        protected int baseAddr;

        public virtual bool Init(GameProcess process)
        {
            proc = process;
            baseAddr = 0x00A9970C;
            return true;
        }

        public void Update(GameTime sender, TimeEventArgs args)
        {
            isLoading = proc.ReadInt32Path(baseAddr, 0) != 0;
            args.CountIn = !isLoading;
        }
    }
}
