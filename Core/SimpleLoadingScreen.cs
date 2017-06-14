using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR.Core
{
    public abstract class SimpleLoadingScreen : IGame
    {
        private GameProcess gameProcess;
        protected IntPtr address;
        private bool isLoading;

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
            isLoading = gameProcess.ReadInt32((int)address) != 0;
        }
    }
}
