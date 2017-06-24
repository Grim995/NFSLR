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
        protected int nisAddr;
        private GameProcess gameProcess;

        private bool isLoading, isNisPlaying;
        private bool crashRecovery;
        
        public virtual bool Init(GameProcess process)
        {
            gameProcess = process;
            return true;
        }

        public void Update(GameTime sender, TimeEventArgs args)
        {
            if(!gameProcess.IsOpen)
            {
                crashRecovery = true;
                return;
            }
            isLoading = gameProcess.ReadInt32(addr) != 2;
            isNisPlaying = gameProcess.ReadInt32(nisAddr) == 4;
            if (crashRecovery)
            {
                crashRecovery = isNisPlaying;
                args.CountIn = !isLoading;
                return;
            }
            args.CountIn = !(isLoading && isNisPlaying);
        }
    }
}
