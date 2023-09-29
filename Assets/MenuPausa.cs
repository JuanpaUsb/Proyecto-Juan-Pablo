using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{
   [SerializeField] private GameObject BotonPausa;
   [SerializeField] private GameObject menuPausa;
   private bool juegopausado = false;
   private void Update(){
    if(Input.GetKeyDown(KeyCode.Escape)){
      if(juegopausado){
        Reaundar();
      }
      else{
        Pausa();
      }
    }
   }
   public void Pausa(){
        juegopausado= true;
        Time.timeScale= 0f;
         BotonPausa.SetActive(false);
         menuPausa.SetActive(true);
   }
   public void Reaundar(){
    juegopausado= false;
    Time.timeScale= 1f;
    BotonPausa.SetActive(true);
    menuPausa.SetActive(false);
   }

   public void Reinicar(){
    
     Time.timeScale= 1f;
     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void Cerrar(){
    Debug.Log("Cerrando juego");
    Application.Quit();
   }
}
