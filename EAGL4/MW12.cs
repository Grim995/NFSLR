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

        private long timePassed = 0;

        //StreamWriter w;

        public virtual bool Init(GameProcess process)
        {
            firstLoadingAddr = 0x00924860;
            secondLoadingAddr = 0x00910ED0;
            pointerBase = 0x0091C8C8;
            prc = process;
            loading = false;
            //w = new StreamWriter("log.log");
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
            if (!prc.IsOpen)
            {
                loading = false;
                return;
            }
            int stat = prc.ReadInt32(firstLoadingAddr);
            //w.WriteLine("{0:X}: {1}", firstLoadingAddr, stat);
            if (stat != 0)
            {
                loading = true;
                return;
            }
            stat = prc.ReadInt32(secondLoadingAddr);
           // w.WriteLine("{0:X}: {1}", secondLoadingAddr, stat);
            if (stat != 0)
            {
                loading = true;
                return;
            }
            loading = false;

            /*{
                w.WriteLine("Pointer path for {0:X}", pointerBase);
                int t = prc.ReadInt32(pointerBase);
                w.WriteLine("{0:X} -> {1:X}", pointerBase, t);
                int b = prc.ReadInt32(t + 0xCC);
                w.WriteLine("[{0:X} + 0xCC] -> {1:x}", t, b);
                t = prc.ReadInt32(b + 0x604);
                w.WriteLine("{0:X} + 0x604 -> {1:X}", b, t);
            }*/

            stat = prc.ReadInt32Path(pointerBase, 0xCC, 0x604);
            //w.WriteLine("{0:X}: {1:X}", pointerBase, stat);
            if (stat != 0)
            {
                loading = true;
                return;
            }
            //w.Flush();
        }
    }
}
