using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C3_movement : MonoBehaviour
{
    public float speed = 3.0f;      // 이동 속도
    public float jump = 3.0f;       // 점프 크기
    public bool canMove = false;    // 이동 가능 여부
    private Rigidbody rb;

    // UI를 통한 이동 가능 여부 제어용
    public void setMoveTrue()
    {
        canMove = true;
    }

    public void setMoveFalse()
    {
        canMove = false;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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

            rb.AddForce(moving * speed * Time.deltaTime + jumping * jump * Time.deltaTime);
        }
    }
}
