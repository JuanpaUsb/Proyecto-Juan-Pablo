using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
   [SerializeField] private float velocidadMovimiento;
   [SerializeField] private Transform[] puntosMovimiento;
   [SerializeField] private float distanciaMinima;

   private int numeroAletorio;

   private SpriteRenderer spriteRenderer;
   private void Start(){
        numeroAletorio= Random.Range(0, puntosMovimiento.Length);
        spriteRenderer= GetComponent<SpriteRenderer>();
        Girar();
   }
   private void Update(){
    transform.position=Vector3.MoveTowards(transform.position, puntosMovimiento[numeroAletorio].position , velocidadMovimiento * Time.deltaTime);
    if(Vector3.Distance(transform.position,puntosMovimiento[numeroAletorio].position)<distanciaMinima){
        numeroAletorio = Random.Range(0,puntosMovimiento.Length);
        Girar();
    }
   }
   private void Girar(){
    if(transform.position.x < puntosMovimiento[numeroAletorio].position.x){
        spriteRenderer.flipX = true;
    }else{
        spriteRenderer.flipX= false;
    }
   }
}
