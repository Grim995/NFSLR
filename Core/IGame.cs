using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFSLR.Core
{
    public interface IGame
    {
        bool Init(GameProcess process);
        void Update(GameTime sender, TimeEventArgs args);
    }
}
