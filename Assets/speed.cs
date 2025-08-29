using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class speed : MonoBehaviour
{
    public Transform LimanTarget;
    public float uzaklýk = 10f;
    public float zoomSpeed = 2f;
    public float rotateSpeed = 100f;
    public float minY = -20f, maxY = 80f;
    float yaw;//yatay 
    float pitch;//dikey

    void Start()
    {
      
    }


    void Update()
    { if (!LimanTarget) return;
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        uzaklýk -= scroll * zoomSpeed;
        uzaklýk = Mathf.Clamp(uzaklýk, 3f, 50f);
       
        if (Input.GetMouseButton(1))
        {
            yaw += Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
            pitch -= Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
            pitch = Mathf.Clamp(pitch, minY, maxY);
        }
        // Pozisyonu hesapla
        Quaternion rot = Quaternion.Euler(pitch, yaw, 0f);
        Vector3 offset = rot * new Vector3(0, 0, -uzaklýk);
        transform.position = LimanTarget.position + offset;
        transform.LookAt(LimanTarget);
    }
 
}
