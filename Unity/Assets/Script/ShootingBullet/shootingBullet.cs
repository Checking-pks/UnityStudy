using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingBullet : MonoBehaviour
{
    public GameObject[] bulletObject;
    public Transform firePosition;
    public int bulletMoveType = 0;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletObject[bulletMoveType]);
            bullet.transform.position = firePosition.position + firePosition.forward;
            bullet.transform.rotation = transform.rotation * Quaternion.Euler(new Vector3(0, -90, 90));
        }
    }

    public void setBulletMoveType(int n)
    {
        bulletMoveType = n;
    }
}
