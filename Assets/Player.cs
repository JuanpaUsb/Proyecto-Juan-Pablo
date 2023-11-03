using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
  public static Player intance;
  public int currentHealth , maxHealth;
  
  private void awake(){
    intance= this;
  }
  void Start(){
    currentHealth = maxHealth; 
  }
   
   public void DealDamage()
   {
    currentHealth--;
    if(currentHealth <= 0)
    {
      gameObject.SetActive(false);
    }
   }
}
