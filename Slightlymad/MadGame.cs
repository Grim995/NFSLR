using System;
using NFSLR.Core;

namespace NFSLR.Slightlymad
{
    public abstract class MadGame : IGame
    {
        protected IntPtr address, address1;
        private GameProcess gameProcess;

        bool isLoading;

        public bool Init(GameProcess process)
        {
            gameProcess = process;
            return true;
        }

        public void Update(GameTime sender, TimeEventArgs args)
        {
            UpdateLoading();
            args.CountIn = !isLoading;
        }

        private void UpdateLoading()
        {
            //isLoading = (gameProcess.ReadInt32((int)address) | gameProcess.ReadInt32((int)address1)) != 0;
            int state = gameProcess.ReadInt32((int)address);
            isLoading = (state == 3 || state == 4);
        }
    }
}
