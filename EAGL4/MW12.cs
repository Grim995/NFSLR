using NFSLR.Core;

namespace NFSLR.EAGL4
{
    public class MW12 : IGame 
    {
        GameProcess prc;
        protected bool loading;

        protected int firstLoadingAddr;
        protected int secondLoadingAddr;
        protected int pointerBase;
        protected int stateAddress;
        protected int state;

        private long timePassed = 0;

        public virtual bool Init(GameProcess process)
        {
            firstLoadingAddr = 0x00924860;
            secondLoadingAddr = 0x00910ED0;
            pointerBase = 0x0091C8C8;
            stateAddress = 0x0091FE14;
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
            state = prc.ReadInt32(stateAddress);
            if(state == 1)
            {
                loading = true;
                return;
            }
            if (!prc.IsOpen)
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

            stat = prc.ReadInt32Path(pointerBase, 0xCC, 0x604);
            if (stat != 0)
            {
                loading = true;
                return;
            }
        }
    }
}
