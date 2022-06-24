using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    public Vector3 movJugador;
    public float velocidad;
    public Vector3 valorEscala;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = valorEscala;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate ((movJugador)*velocidad*Time.deltaTime);
    }
   

}
