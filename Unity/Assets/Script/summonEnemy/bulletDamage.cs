using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamage : MonoBehaviour
{
    public int Damage = 60;     //공격력

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<enemyHealth>().Health -= Damage;
            Destroy(gameObject);
        }
    }
}
