using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public float Health = 100;    //체력

    private Image healthBar;
    private Text killCount;

    void Start()
    {
        healthBar = transform.GetChild(0).GetChild(0).GetComponent<Image>();
    }

    void Update()
    {
        healthBar.fillAmount = Health / 100;

        if (Health <= 0)
        {
            GameObject.Find("Bottom").GetComponent<state>().killCount++;
            Destroy(gameObject);
        }
    }
}
