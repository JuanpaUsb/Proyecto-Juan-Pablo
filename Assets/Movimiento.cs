using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidadcaidarapida;
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.81f;
     public static bool growup;
    public Animator animator;
    
    private AudioSource SonidosDeSalto;
    private AudioSource SonidosDeMuerte;

     void Start()
    {
        controller = this.GetComponent<CharacterController>();
        SonidosDeSalto = GetComponent<AudioSource>();
        SonidosDeMuerte= GetComponent<AudioSource>();
         growup = false;
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            gravityValue = -9.81f;
            playerVelocity.y = 0f;
            velocidadcaidarapida = 1;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);


        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
       
        // Changes the height position of the player..
        if (Input.GetButton("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            SonidosDeSalto.Play();
        }

        if(Input.GetButtonUp("Jump")){
            velocidadcaidarapida = 2;
            gravityValue = gravityValue * velocidadcaidarapida;
        }


        playerVelocity.y += gravityValue * velocidadcaidarapida * Time.deltaTime;
        //playerVelocity.y=(velocidadcaidarapida*gravityValue);
        controller.Move(playerVelocity * Time.deltaTime);
        if(growup)
        {
            animator.SetBool("Growup",growup);
        }
    }
}
 