using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class state : MonoBehaviour
{
    public int killCount = 0;

    // Update is called once per frame
    void Update()
    {
        setKillCountUI();
    }

    void setKillCountUI()
    {
        GameObject.Find("Text").GetComponent<Text>().text = "Kills : " + killCount;
    }
}
