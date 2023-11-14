using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
   public AudioSource deathSound;
   public Renderer renderer;


IEnumerator FadeAndPlayDeathSound()
    {
        // Inicia el desvanecimiento
        
       
for (float f = 1f; f >= 0; f -= 0.1f)
  {
    yield return new WaitForSeconds(3f);
        }

        // Reproduce el sonido de muerte
        if (deathSound != null)
        {
            deathSound.Play();
        }

        
        {
            deathSound.Play();
        }


        
            deathSound.Play();

        {

        {
  }
        }
    }
}
