using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Transform cameraTransform;   // 카메라 Transform
    public float speed = 7.0f;          // 이동 속도

    void FixedUpdate()
    {
        CameraMoving();

        // 앞면 처리
        Vector3 head = cameraTransform.localRotation * Vector3.forward;
        head.y = 0;
        head = head.normalized;

        // 이동 처리
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moving = Vector3.right * h + Vector3.forward * v;

        transform.position += moving * speed * Time.deltaTime;
    }

    void CameraMoving()
    {
        cameraTransform.position = transform.position + new Vector3(0, 7f, -8f);
    }
}