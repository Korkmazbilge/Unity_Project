using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatFloat : MonoBehaviour
{
    public float amplitude = 0.2f;  // Sallanma y�ksekli�i
    public float frequency = 1f;    // Sallanma h�z�
    public float tiltAmount = 2f;   // Geminin sa�a sola e�ilme miktar�

    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    void Update()
    {
        // Y ekseninde hafif yukar� a�a�� hareket
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude;

        // Hafif sa�a sola e�ilme
        float tiltZ = Mathf.Sin(Time.time * frequency) * tiltAmount;

        transform.position = new Vector3(startPos.x, newY, startPos.z);
        transform.rotation = startRot * Quaternion.Euler(0, 0, tiltZ);
        
    }
}
