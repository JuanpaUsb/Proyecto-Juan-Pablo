using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    if(other.tag == "Player")
    {
      Debug.Log("Hit");
    }
  }
}
