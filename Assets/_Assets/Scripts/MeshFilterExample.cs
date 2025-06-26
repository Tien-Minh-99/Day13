using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshFilterExample : MonoBehaviour
{

    public MeshFilter myMeshfilter;
    public Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        myMeshfilter.mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
