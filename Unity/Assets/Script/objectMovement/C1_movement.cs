using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1_movement : MonoBehaviour
{
    public float speed = 3.0f;      // 이동 속도
    public float jump = 3.0f;       // 점프 크기
    public bool canMove = false;    // 이동 가능 여부

    public void setMoveTrue()   // UI를 통한 이동 가능 여부 제어용
    {
        canMove = true;
    }

    public void setMoveFalse()
    {
        canMove = false;
    }

    void Update()
    {
        if (canMove)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            float j = Input.GetAxis("Jump");

            Vector3 moving = Vector3.right * h + Vector3.forward * v;
            Vector3 jumping = Vector3.up * j;

            transform.position += (moving * speed * Time.deltaTime) + (jumping * jump * Time.deltaTime);
        }
    }
}