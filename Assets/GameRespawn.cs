using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
 public float threshold;
  void FixedUpdate()
  {
        if(transform.position.y < threshold){
            transform.position = new Vector3(-59.33496f,-0.46f,-61.93559f);
        }
    }
}