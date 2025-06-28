using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyExample : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float tocDo = 4;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody.mass = 5.0f;// thay đổi khối lượng 

      
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = Vector3.right * tocDo;
        // di chuyển theo vector3 ( liên tục di chuyển qua phải với tốc độ = 4 )
    }
}
