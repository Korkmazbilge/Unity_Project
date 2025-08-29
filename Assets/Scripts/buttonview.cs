using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butonview : MonoBehaviour
{

    public Camera mainCamera;
    public Transform dagView;
    public Transform limanView;
    public Transform rihtimView;
    public Transform KonteynerView;

    public Transform dagTarget;     // bakýlacak hedef (ör: daðdaki boþ obje)
    public Transform limanTarget;
    public Transform rihtimTarget;
    public Transform KonteynerTarget;
    public void GoDag()
    {
        mainCamera.transform.position = dagView.position;
        mainCamera.transform.LookAt(dagTarget);
    }

    public void GoLiman()
    {
        mainCamera.transform.position = limanView.position;
        mainCamera.transform.LookAt(limanTarget);
    }

    public void GoRihtim()
    {
        mainCamera.transform.position = rihtimView.position;
        mainCamera.transform.LookAt(rihtimTarget);
    }
    public void GoKontey()
    {
        mainCamera.transform.position = KonteynerView.position;
        mainCamera.transform.LookAt(KonteynerTarget);
    }
}
