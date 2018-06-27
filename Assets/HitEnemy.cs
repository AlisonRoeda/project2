using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{

    public int AttackDamage;

    void OnTriggerEnter(Collider other)
    {

        threatstat threatstat = other.gameObject.GetComponent<threatstat>();
        if (threatstat != null)
        {
            threatstat.UpdateHealth(AttackDamage);
        }
    }
}
