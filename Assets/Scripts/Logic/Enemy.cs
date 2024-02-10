using Game.Infrastructure.Services.PlayerProgress;
using UnityEngine;
using Zenject;

namespace Game.Logic
{
    public class Enemy : MonoBehaviour, IProgressReader
    {
        private IProgressService _progressService;

        [Inject]
        private void Construct(IProgressService progressService) => _progressService = progressService;

        public void Initialize() => _progressService.AddProgressReader(this);
        public void Load(Progress progress) => throw new System.NotImplementedException();
    }
}