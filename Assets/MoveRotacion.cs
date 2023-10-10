using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotacion : MonoBehaviour
{
   private CharacterController controller;
   private Vector3 playerVelocityInitial;
   public bool groundedplayer;
   public float playerSpeed = 20.0f;
   public float horizontal = 1f;

   public void Start(){
     controller= gameObject.GetComponent<CharacterController>();
   }
    void Update () {
    //if (GameManager.activado == false) return;

    Vector3 move = new Vector3(horizontal, 0, /*Input.GetAxis("Vertical")*/0);
    controller.Move(move* Time.deltaTime * playerSpeed);    
    }
   public void OnControllerColliderHit(ControllerColliderHit hit){
    Debug.Log("Choco");

    horizontal = horizontal* -1;
   }
}
