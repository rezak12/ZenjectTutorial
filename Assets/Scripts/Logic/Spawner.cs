using Game.Infrastructure.Services.Factories;
using UnityEngine;
using Zenject;

namespace Game.Logic
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        private IEnemyFactory _factory;

        [Inject]
        private void Construct(IEnemyFactory factory) => _factory = factory;

        public void Spawn() => _factory.Create(_spawnPoint.position);
    }
}
