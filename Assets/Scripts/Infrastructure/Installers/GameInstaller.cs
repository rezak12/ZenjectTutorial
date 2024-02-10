using Game.Infrastructure.Services.Factories;
using Game.Infrastructure.Services.PlayerProgress;
using Game.Logic;
using UnityEngine;
using Zenject;

namespace Game.Infrastructure.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private Spawner _spawner;
        
        public override void InstallBindings()
        {
            BindFactory();
            BindProgress();
            BindSpawner();
        }

        private void BindProgress()
        {
            Container.BindInterfacesTo<ProgressService>().AsSingle();
        }

        private void BindFactory()
        {
            Container.BindInterfacesTo<EnemyFactory>().AsSingle();
        }

        private void BindSpawner()
        {
            Container.BindInstance(_spawner);
        }
    }
}