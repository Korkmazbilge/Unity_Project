using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class KameraPozisyon : MonoBehaviour
{
    public Camera MainCamera;
    public Transform Limanview;
    public Transform Dagview;
    public Transform RihtimTarget;
    public Transform Rihtimview;
    public Transform DagTarget;
    public Transform LimanTarget;

    public void dagGor()
    {
        MainCamera.transform.position=Dagview.transform.position;
        MainCamera.transform.LookAt(DagTarget);
    }
    
    public void limanGor()
    {
         MainCamera.transform.position= Limanview.transform.position;
        MainCamera.transform.LookAt(LimanTarget);
    }
   
    public void rihtimGor()
    {
        MainCamera.transform.position=Rihtimview.transform.position;
        MainCamera.transform.LookAt(RihtimTarget);

    }
  
}




   