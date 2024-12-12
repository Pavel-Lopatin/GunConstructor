using UnityEngine;
using DG.Tweening;

namespace GC.Code.Gameplay.CameraSystem
{
    public class CameraManualMovementController : Transform
    {
        public void MoveTo(Transform finalPoint, float duration)
        {
            transform.DOLocalMove(finalPoint.position, duration).Kill();
            transform.DOLocalRotate(finalPoint.eulerAngles, duration).Kill();
        }
    }
}

