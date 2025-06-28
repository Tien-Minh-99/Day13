using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExample : MonoBehaviour
{
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera.backgroundColor = Color.cyan;// đổi màu màn hình camera
        mainCamera.clearFlags = CameraClearFlags.SolidColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
