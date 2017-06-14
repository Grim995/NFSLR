namespace NFSLR.Core
{
    public class GameTime
    {
        private long time;
        private IGame game;

        public long Time
        {
            get
            {
                return time;
            }
        }

        internal void Update(long ms)
        {
            TimeEventArgs args = new TimeEventArgs(ms);
            game.Update(this, args);
            if (args.CountIn)
                time += ms;
        }

        public GameTime(IGame g)
        {
            game = g;
        }

        public void Reset()
        {
            time = 0;
        }

        public void Add(long ms)
        {
            time += ms; 
        }

        public void Remove(long ms)
        {
            time -= ms;
        }
    }
}
