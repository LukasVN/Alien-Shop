using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagement : MonoBehaviour
{
    public GameObject camera_1;
    public GameObject camera_2;
    public GameObject camera_3;
    void Start()
    {
        camera_1.SetActive(true);
        camera_2.SetActive(false);
        camera_3.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && !camera_1.activeSelf){
            camera_1.SetActive(true);
            camera_2.SetActive(false);
            camera_3.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2) && !camera_2.activeSelf){
            camera_1.SetActive(false);
            camera_2.SetActive(true);
            camera_3.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3) && !camera_3.activeSelf){
            camera_1.SetActive(false);
            camera_2.SetActive(false);
            camera_3.SetActive(true);
        }
    }
}
