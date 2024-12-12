using UnityEngine;

namespace GC.Code.Gameplay.Root
{
    public class GameplayEntryPoint : MonoBehaviour
    {
        [SerializeField] private GameplayContainer _gameplayContainerPrefab;

        public void Run()
        {
            GameplayContainer newContainer = Instantiate(_gameplayContainerPrefab, Vector3.zero, transform.rotation);
            newContainer.Run();
            Debug.Log("Gameplay started!");
        }
    }
}
