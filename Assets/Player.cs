using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
   public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Aquí puedes implementar las acciones que deseas cuando el jugador muere, como cargar una pantalla de Game Over o reiniciar el nivel.
        Debug.Log("El jugador ha muerto");
        // Ejemplo: GameManager.Instance.GameOver();
    }
}
