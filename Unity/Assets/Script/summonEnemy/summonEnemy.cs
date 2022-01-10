using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonEnemy : MonoBehaviour
{
    public GameObject Enemy;            // 적 오브젝트
    public float spawnCooldown = 10.0f; // 스폰 쿨타임

    private float nowCooldown;

    void Start()
    {
        nowCooldown = spawnCooldown;
    }

    void Update()
    {
        nowCooldown -= Time.deltaTime;

        if (nowCooldown <= 0)
        {
            GameObject e = Instantiate(Enemy);

            switch (Random.Range(0,4))
            {
                case 0:
                    e.transform.position = new Vector3(Random.Range(-17, 18), 0, 17);
                    break;
                case 1:
                    e.transform.position = new Vector3(17, 0, Random.Range(-17, 18));
                    break;
                case 2:
                    e.transform.position = new Vector3(Random.Range(-17, 18), 0, -17);
                    break;
                case 3:
                    e.transform.position = new Vector3(-17, 0, Random.Range(-17, 18));
                    break;
            }

            nowCooldown = spawnCooldown;
        }
    }
}
