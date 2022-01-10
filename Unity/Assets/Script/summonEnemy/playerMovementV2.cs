using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementV2 : MonoBehaviour
{
    public float speed = 3.0f;          // 이동 속도
    public float xSensitivity = 3.0f;   // x축 감도

    public float mouseXPos = 0;

    void FixedUpdate()
    {
        // Player Movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moving = transform.right * h + transform.forward * v;

        transform.position += moving * speed * Time.deltaTime;

        // Player Rotation
        if (Input.GetMouseButton(1))
        {
            if (mouseXPos == 0) mouseXPos = Input.mousePosition.x;
            transform.rotation *= Quaternion.Euler(0, (mouseXPos - Input.mousePosition.x) * xSensitivity * Time.deltaTime, 0);
        }

        if (Input.GetMouseButtonUp(1))
        {
            mouseXPos = 0;
        }
    }
}