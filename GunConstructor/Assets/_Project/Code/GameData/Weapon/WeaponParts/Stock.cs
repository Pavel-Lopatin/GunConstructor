using UnityEngine;

namespace GC.Code.GameData.Weapon
{
    public class Stock : WeaponPart
    {
        protected override void Attach(Transform gunAttachmentPoint)
        {
            Debug.Log($"{GetType().Name} attached!");
        }
    }
}

