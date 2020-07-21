using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDron : MonoBehaviour
{
    public DroneCamera dronCamera;
    bool dronCameraActive;

    private void Start()
    {
        dronCameraActive = false;
    }

    void LateUpdate()
    {
        if (!dronCameraActive)
        {
            dronCamera.enabled = true;
            dronCameraActive = true;
        }        
    }
}
