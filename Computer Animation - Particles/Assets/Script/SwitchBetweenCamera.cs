using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBetweenCamera : MonoBehaviour {

    public Camera firstCamera;
    public Camera SecondCamera;
    public Camera ThirdCamera;

    private int count = 0;

    private void Start()
    {
        firstCamera.enabled = true;
        SecondCamera.enabled = false;
        ThirdCamera.enabled = false;
    }

    private void Update()
    {
        switchCamera();
    }

    void switchCamera()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            if(count == 0)
            {
                firstCamera.enabled = false;
                SecondCamera.enabled = true;
                ThirdCamera.enabled = false;
                count++;
            }
            else if(count == 1)
            {
                firstCamera.enabled = false;
                SecondCamera.enabled = false;
                ThirdCamera.enabled = true;
                count++;
            }
            else
            {
                count = 0;
                firstCamera.enabled = true;
                SecondCamera.enabled = false;
                ThirdCamera.enabled = false;
            }
            
        }
    }

    

}
