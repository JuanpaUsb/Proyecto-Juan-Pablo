using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sumar : MonoBehaviour
{
   [SerializeField] private float cantidadPuntos;
   [SerializeField] private Puntaje puntaje;
   [SerializeField] private AudioSource audioSource;

   private void OnTriggerEnter(Collider other)
   {
    puntaje.SumarPuntos(cantidadPuntos);
    audioSource.Play();
   }
}
