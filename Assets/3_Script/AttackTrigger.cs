using UnityEngine;
using System.Collections;

public class AttackTrigger : MonoBehaviour
{
    public int dmg = 20;

    void OnTriggerEnter(Collider col)
    {
        if (col.isTrigger != true && col.CompareTag("Enemy"))
        {
            col.SendMessageUpwards("Damage", dmg);
        }
    }
}
