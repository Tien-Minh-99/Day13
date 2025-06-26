using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightExample : MonoBehaviour
{
    public Light myLight;
    // Start is called before the first frame update
    void Start()
    {
        myLight.color = Color.black;// đổi màu của light
        myLight.intensity = 2.0f;// kích thước của light

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
