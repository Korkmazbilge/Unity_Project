using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAyar : MonoBehaviour
{
    public List<Transform> cameraPositions;
    public Camera mainCamera;
    private int index = 0;
    void Start()
    {
        
        if (cameraPositions.Count > 0)
        {
            KameraPozisyon();
        }

        
        
        
        
        }

    
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.D))
        {
            index = (index + 1) % cameraPositions.Count;
            KameraPozisyon();
        }
    }
    void KameraPozisyon()
    {
        Debug.Log("Kamera Açýsý deðiþtirildi :" + index);
        mainCamera.transform.position = cameraPositions[index].position;
        mainCamera.transform.rotation = cameraPositions[index].rotation;
        
    
    
    
    }
}
