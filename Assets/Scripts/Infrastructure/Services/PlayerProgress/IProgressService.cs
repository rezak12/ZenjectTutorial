namespace Game.Infrastructure.Services.PlayerProgress
{
    public interface IProgressService
    {
        void AddProgressReader(IProgressReader reader);
    }
}