using Game.Data;
using Game.Logic;
using UnityEngine;

namespace Game.Infrastructure.Services.Factories
{
    public class EnemyFactory
    {
        public Enemy Create(Vector3 position)
        {
            var prefab = Resources.Load<Enemy>(Constants.EnemyPrefabPath);
            Enemy enemy = Object.Instantiate(prefab, position, Quaternion.identity);
            
            enemy.Initialize();
            return enemy;
        }
    }
}