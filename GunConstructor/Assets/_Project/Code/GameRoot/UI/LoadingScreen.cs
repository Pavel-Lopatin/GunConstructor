using UnityEngine;

namespace GC.Code.GameRoot.UI
{
    public class LoadingScreen : MonoBehaviour
    {
        [SerializeField] private GameObject _loadingScreenCanvas;

        private void Awake()
        {
            HideLoadingScreen();
        }

        public void ShowLoadingScreen()
        {
            _loadingScreenCanvas.SetActive(true);
        }

        public void HideLoadingScreen()
        {
            _loadingScreenCanvas.SetActive(false);
        }
    }
}