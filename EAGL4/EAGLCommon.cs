using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFSLR.Core;

namespace NFSLR.EAGL4
{
    public abstract class EAGLCommon : NFSLR.Core.IGame
    {
        GameProcess prc;
        protected bool loading;

        protected int firstLoadingAddr;
        protected int secondLoadingAddr;

        private long timePassed = 0;

        public virtual bool Init(GameProcess process)
        {
            prc = process;
            loading = false;
            return true;
        }

        public void Update(GameTime sender, TimeEventArgs args)
        {
            RefreshStatus();
            if (loading)
            {
                args.CountIn = false;
                if (timePassed < 100)
                    sender.Remove(timePassed);
                timePassed = 0;
                return;
            }
            timePassed += args.TimePassed;
        }

        public virtual void RefreshStatus()
        {
            if(!prc.IsOpen)
            {
                loading = false;
                return;
            }
            int stat = prc.ReadInt32(firstLoadingAddr);
            if (stat != 0)
            {
                loading = true;
                return;
            }
            stat = prc.ReadInt32(secondLoadingAddr);
            if (stat != 0)
            {
                loading = true;
                return;
            }
            loading = false;
        }
    }
}
