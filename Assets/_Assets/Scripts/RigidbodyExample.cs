using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyExample : MonoBehaviour
{
    public Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.mass = 5.0f;// thay đổi khối lượng 

        myRigidbody.velocity = Vector3.one;// di chuyển theo vector3 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
