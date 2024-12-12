using GC.Code.Gameplay.UI;
using UnityEngine;

namespace GC.Code.Gameplay.Root
{
    public class GameplayContainer : MonoBehaviour
    {
        [SerializeField] private MenuTransitionController _menuTransitionController;
        [SerializeField] private float _transitionDuration;
        [SerializeField] private OverviewPanel _startPanel;

        public float TransitionDuration => _transitionDuration;
        public OverviewPanel StartPanel => _startPanel;

        public void Run()
        {
            _menuTransitionController.Run(this);
        }
    }
}