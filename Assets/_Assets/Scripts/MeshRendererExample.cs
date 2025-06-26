using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererExample : MonoBehaviour
{
    public MeshRenderer myMeshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myMeshRenderer.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
