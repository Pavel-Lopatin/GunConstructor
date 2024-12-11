using UnityEngine;

namespace GC.Code.Gameplay.Root
{
    public class GameplayEntryPoint : MonoBehaviour
    {
        [SerializeField] private GameObject _gameplayContainer;

        public void Run()
        {
            Instantiate(_gameplayContainer, Vector3.zero, transform.rotation);
            Debug.Log("Gameplay started!");
        }
    }
}
