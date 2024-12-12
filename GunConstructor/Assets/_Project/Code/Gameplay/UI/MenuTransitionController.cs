using GC.Code.Gameplay.Root;
using System;
using UnityEngine;

namespace GC.Code.Gameplay.UI
{
    public class MenuTransitionController : MonoBehaviour
    {
        private OverviewPanel _startPanel;
        private OverviewPanel _currentPanel;
        private GameplayContainer _container;

        private float _transitionDuration;

        public void Run(GameplayContainer gameplayContainer)
        {
            _container = gameplayContainer;
            SetParameters();
            SetCurrentPanel(_startPanel);
        }

        private void SetParameters()
        {
            _startPanel = _container.StartPanel;
            _transitionDuration = _container.TransitionDuration;
        }

        public void TransitionTo(OverviewPanel nextPanel)
        {
            _currentPanel.Hide(_transitionDuration);
            SetCurrentPanel(nextPanel);
        }

        private void SetCurrentPanel(OverviewPanel currentPanel)
        {
            _currentPanel = currentPanel;
            ShowCurrentPanel();
        }

        private void ShowCurrentPanel()
        {
            _currentPanel.Show(_transitionDuration);
        }

        private void HideCurrentPanel() 
        {
            _currentPanel.Hide(_transitionDuration);
        }
    }
}