using UnityEngine;
namespace GC.Code.GameData.Weapon
{
    public class Barrel : WeaponPart
    {
        protected override void Attach(Transform gunAttachmentPoint)
        {
            Debug.Log($"{GetType().Name} attached!");
        }
    }
}
