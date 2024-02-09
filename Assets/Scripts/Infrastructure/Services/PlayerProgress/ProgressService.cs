using System.Collections.Generic;

namespace Game.Infrastructure.Services.PlayerProgress
{
    public class ProgressService : IProgressService
    {
        private readonly List<IProgressReader> _progressReaders = new();
        
        public void AddProgressReader(IProgressReader reader) => _progressReaders.Add(reader);
    }
}