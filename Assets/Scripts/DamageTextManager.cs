using UnityEngine;

public class DamageTextManager : MonoBehaviour
{
   [SerializeField]
   private InstantiatePoolObjects damageTextPool;
   [SerializeField]
   private Transform canvasTransform;
   public void ShowDmage(DamageTarget damageTarget)
    {
        damageTextPool.InstantiateObject(Vector3.zero);
        DamageText damageText = damageTextPool.GetCurrentObject().GetComponent<DamageText>();
        damageText.transform.SetParent(canvasTransform, false);
        damageText.ShowDamage(damageTarget);
    }
}
