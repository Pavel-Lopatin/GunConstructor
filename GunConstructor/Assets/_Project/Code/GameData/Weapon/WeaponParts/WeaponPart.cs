using UnityEngine;

namespace GC.Code.GameData.Weapon
{
    public abstract class WeaponPart : MonoBehaviour
    {
        protected Transform _attachmentPoint;
        protected bool _isAttached;

        // TODO
        // Add void TryAttach()
        // Add void Detach()
        // Add parameter attachTarget

        protected abstract void Attach(Transform gunAttachmentPoint);
    }
}

