using Game.Infrastructure.Services.PlayerProgress;
using UnityEngine;

namespace Game.Logic
{
    public class Enemy : MonoBehaviour, IProgressReader
    {
        private IProgressService _progressService;
        public void Initialize() => _progressService.AddProgressReader(this);
        public void Load(Progress progress) => throw new System.NotImplementedException();
    }
}