using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Prefab_Bala;
    public Transform Torreta;

    // Start is called before the first frame update
    void Start()
    {
        CrearProyectil();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CrearProyectil()
    {
        Instantiate(Prefab_Bala,Torreta.position,transform.rotation);
    }
}
