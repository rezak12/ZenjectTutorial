using Game.Logic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class SpawnerInteractionPanel : MonoBehaviour
    {
        [SerializeField] private Button _button;
        private Spawner _spawner;

        private void OnEnable() => _button.onClick.AddListener(Spawn);
        private void OnDisable() => _button.onClick.RemoveListener(Spawn);

        private void Spawn() => _spawner.Spawn();
    }
}