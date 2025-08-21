using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraPozisyon : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Transform> cameraPositions;
    public int currentIndex = 0;
    public Camera mainCamera;
    void Start()
    {
        MoveCameraToIndex(currentIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentIndex = (currentIndex + 1) % cameraPositions.Count;
            MoveCameraToIndex(currentIndex);
        }
    }


    void MoveCameraToIndex(int index)
    {
        mainCamera.transform.position = cameraPositions[index].position;
        mainCamera.transform.rotation = cameraPositions[index].rotation;
    }

    public void GoToCamera(int index)
    {
        if (index >= 0 && index < cameraPositions.Count)
        {
            currentIndex = index;
            MoveCameraToIndex(currentIndex);
        }
    }

}
