using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hongo : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocityInicial;
    public bool groundedPlayer;
    public float playerSpeed = 20.0f;
    public float horizontal = 1f;
    public float gravityValue = -9.81f;
    private GameObject Player;
   
    // Start is called before the first frame update
     private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");    
        controller = gameObject.GetComponent<CharacterController>();    
    }

    // Update is called once per frame
    void Update()
    {
        //if(GameManager.activado == false) return;
        gravityValue = -9.81f;
        Vector3 move = new Vector3(horizontal, 0,/*Input.GetAxis("Vertical")*/0);
        controller.Move(move * Time.deltaTime * playerSpeed);
    }
    public void OnControllerColliderHit(ControllerColliderHit hit){
       
        horizontal = horizontal * -1;
}
private void OnTriggerEnter(Collider collision)
    {
        // Comprueba si el objeto que cayó encima cumple con ciertos criterios (puedes personalizar esto).
        if (collision.gameObject.CompareTag("Player"))
        {
        Destroy(gameObject);
        Movimiento.growup = true;
        }
    }
}
