using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
    public int vidajugador = 1;
    public float velocidad;
    public Vector3 direccion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        RestarVidaJugador();
               
        if (vidajugador < 10)
        {
            SumarVidaJugador();
        }
            
    }

    void MovimientoJugador()
    {
        transform.Translate((direccion) * velocidad * Time.deltaTime);
    }

    void SumarVidaJugador()
    {

         vidajugador += 1;      
        
    }

    void RestarVidaJugador()
    {
        if (vidajugador == 10)
        {
            vidajugador = -1;
        }
            
        if(vidajugador == 0)
        {
            Debug.Log("El jugador está muerto");
        }
    }
}
