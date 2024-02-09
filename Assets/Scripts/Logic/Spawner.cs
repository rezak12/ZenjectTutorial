using Game.Infrastructure.Services.Factories;
using UnityEngine;

namespace Game.Logic
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        private EnemyFactory _factory;

        public void Spawn() => _factory.Create(_spawnPoint.position);
    }
}
