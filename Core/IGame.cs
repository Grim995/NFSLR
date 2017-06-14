namespace NFSLR.Core
{
    public interface IGame
    {
        bool Init(GameProcess process);
        void Update(GameTime sender, TimeEventArgs args);
    }
}
