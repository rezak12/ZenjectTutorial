using Game.Logic;
using UnityEngine;

namespace Game.Infrastructure.Services.Factories
{
    public interface IEnemyFactory
    {
        Enemy Create(Vector3 position);
    }
}