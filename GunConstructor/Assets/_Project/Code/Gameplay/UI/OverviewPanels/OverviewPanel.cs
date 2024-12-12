using DG.Tweening;
using System;
using UnityEngine;

namespace GC.Code.Gameplay.UI
{
    public abstract class OverviewPanel : MonoBehaviour
    {
        [SerializeField] protected RectTransform[] _panelElements;
        [SerializeField, Range(0.1f, 1f)] protected float _showDuration;
        [SerializeField, Range(0.1f, 1f)] protected float _hideDuration;

        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            foreach (var element in _panelElements)
            {
                element.transform.localScale = Vector3.zero;
            }
        }

        public virtual void Show(float duration)
        {
            gameObject.SetActive(true);

            for (int i = 0; i < _panelElements.Length; i++)
            {
                var element = _panelElements[i];
                element.DOScale(Vector3.one, duration).SetAutoKill(true);
            }
        }

        public virtual void Hide(float duration)
        {
            for (int i = 0; i < _panelElements.Length; i++)
            {
                var element = _panelElements[i];
                element.DOScale(Vector3.zero, duration).SetAutoKill(true);
            }

            gameObject.SetActive(false);
        }

        // old
        /*
            _sequence = DOTween.Sequence();

            foreach (var element in _elements)
            {
                Tween newTween = element.DOScale(Vector3.zero, _hideDuration);
                _sequence.Append(newTween);
            }
            _sequence.Play().OnComplete(() => _sequence.Kill());
        */
    }
}