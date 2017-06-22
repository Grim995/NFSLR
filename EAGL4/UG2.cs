using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR.EAGL4
{
    using Core;
    public abstract class UG2 : IGame
    {
        protected int addr;
        private GameProcess gameProcess;

        private bool isLoading;
        
        public virtual bool Init(GameProcess process)
        {
            gameProcess = process;
            return true;
        }

        public void Update(GameTime sender, TimeEventArgs args)
        {
            isLoading = gameProcess.ReadInt32(addr) != 2;
            args.CountIn = !isLoading;
        }
    }
}
