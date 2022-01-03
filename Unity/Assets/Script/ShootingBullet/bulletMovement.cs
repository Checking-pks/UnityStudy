using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    public float speed = 5.0f;  // 총알 속도
    public float life = 5.0f;   // 총알이 남아있는 시간

    void FixedUpdate()
    {
        // 이동 처리
        transform.position += -transform.up * speed * Time.deltaTime;

        // 총알 제거 처리
        life -= Time.deltaTime;
        if (life <= 0) Destroy(gameObject);
    }
}
