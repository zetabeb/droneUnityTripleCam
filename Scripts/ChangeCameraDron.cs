using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraDron : MonoBehaviour
{
    public GameObject camera360;
    public GameObject camera2;
    public GameObject camera3;
    bool cam360;
    bool cam2;
    bool cam3;
    bool camera360Found;

    private void Start()
    {
        camera360Found = false;
        cam360 = true;
        cam2 = false;
        cam3 = false;
        camera2.SetActive(false);
        camera3.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (cam360)
            {                
                OnCamera2();
                Debug.Log("Cambiar a camara 2");
            }

            else if (cam2)
            {
                OnCamera3();
                Debug.Log("Cambiar a camara 3");
            }
            else if (cam3)
            {
                OnCamera360();
                Debug.Log("Cambiar a camara 360");
            }
        }
    }
    private void LateUpdate()
    {
        if (!camera360Found)
        {
            camera360 = GameObject.Find("360UnwrappedRT2(Clone)");
            camera360Found = true;
        }        
    }

    public void OnCamera360()
    {
        camera360.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        cam360 = true;
        cam2 = false;
        cam3 = false;
    }

    public void OnCamera2()
    {
        camera360.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);
        cam360 = false;
        cam2 = true;
        cam3 = false;
    }

    public void OnCamera3()
    {
        camera360.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);
        cam360 = false;
        cam2 = false;
        cam3 = true;
    }
}
