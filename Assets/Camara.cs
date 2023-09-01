using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public Transform Cube;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset=Cube.position-transform.position;

       
    }

    // Update is called once per frame
    void Update()

    {
        if(Cube != null){
            transform.position=Cube.position-offset;
        }

       
       
    }
    }
