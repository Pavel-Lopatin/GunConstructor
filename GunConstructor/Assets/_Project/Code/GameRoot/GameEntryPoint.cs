using GC.Code.Gameplay.Root;
using GC.Code.GameRoot.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GC.Code.GameRoot
{
    public class GameEntryPoint
    {
        private static GameEntryPoint _instance;
        private Coroutines _coroutines;
        private LoadingScreen _loadingScreen;

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void StartGame()
        {
            _instance = new GameEntryPoint();
            _instance.SelectScene();
        }

        private GameEntryPoint()
        {
            // TODO system settings
            // TODO init services

            _coroutines = new GameObject("Coroutines").AddComponent<Coroutines>();
            Object.DontDestroyOnLoad(_coroutines.gameObject);

            var loadingScreenPrefab = Resources.Load<LoadingScreen>("LoadingScreen");
            _loadingScreen = Object.Instantiate(loadingScreenPrefab);
            Object.DontDestroyOnLoad(_loadingScreen);
        }

        private void SelectScene()
        {
            _coroutines.StartCoroutine(LoadAndStartMainScene());
        }

        private IEnumerator LoadAndStartMainScene()
        {
            _loadingScreen.ShowLoadingScreen();

            yield return LoadScene(Scenes.BOOT);
            yield return LoadScene(Scenes.GAMEPLAY);
            yield return new WaitForSeconds(1);

            var gameplayEntryPoint = Object.FindFirstObjectByType<GameplayEntryPoint>();
            gameplayEntryPoint.Run();
            _loadingScreen.HideLoadingScreen();
        }

        private IEnumerator LoadScene(string sceneName)
        {
            yield return SceneManager.LoadSceneAsync(sceneName);
        }
    }
}

