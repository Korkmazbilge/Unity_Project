using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatFloat : MonoBehaviour
{
    public float amplitude = 0.2f;  // Sallanma yüksekliði
    public float frequency = 1f;    // Sallanma hýzý
    public float tiltAmount = 2f;   // Geminin saða sola eðilme miktarý

    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
    }

    void Update()
    {
        // Y ekseninde hafif yukarý aþaðý hareket
        float newY = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude;

        // Hafif saða sola eðilme
        float tiltZ = Mathf.Sin(Time.time * frequency) * tiltAmount;

        transform.position = new Vector3(startPos.x, newY, startPos.z);
        transform.rotation = startRot * Quaternion.Euler(0, 0, tiltZ);
        
    }
}
