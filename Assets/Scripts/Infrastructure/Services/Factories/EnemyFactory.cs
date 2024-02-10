using System;
using Game.Data;
using Game.Logic;
using UnityEngine;
using Zenject;

namespace Game.Infrastructure.Services.Factories
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly IInstantiator _instantiator;

        public EnemyFactory(IInstantiator instantiator)
        {
            _instantiator = instantiator;
        }

        public Enemy Create(Vector3 position)
        {
            var prefab = Resources.Load<Enemy>(Constants.EnemyPrefabPath);
            var enemy = _instantiator.InstantiatePrefabForComponent<Enemy>(prefab, position, Quaternion.identity, null);

            enemy.Initialize();
            return enemy;
        }
    }
}