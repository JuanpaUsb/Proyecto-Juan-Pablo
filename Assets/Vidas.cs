using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public int maxLives = 3;
    private int currentLives;
    private Vector3 respawnPoint;
    private CharacterController characterController;
    public GameObject corazon1;
    public GameObject corazon2;
    public GameObject corazon3;


    public void Start()
    {
        characterController = GetComponent<CharacterController>();
        currentLives= maxLives;
        respawnPoint = transform.position;
    }
    private void Update()
    {
        if(transform.position.y<-10f)
        {
            LoseLife();
        }
    }
   private void LoseLife()
   {
    currentLives--;
    if (currentLives >0)
    {
        Respawn();
        if(currentLives == 2){
            corazon3.SetActive(false);
        }else if (currentLives ==1){
            corazon2.SetActive(false);
        }
    }
     else{
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     }
   }
   private void Respawn(){
    characterController.enabled=false;
    transform.position=respawnPoint;
    characterController.enabled=true;
   }
}


