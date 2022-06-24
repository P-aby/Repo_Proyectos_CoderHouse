using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio_complementario_Cañon : MonoBehaviour
{
    public GameObject Prefab_Bala;
    public Transform Torreta;
    public int numberOfObjectsL = 4;
    public int numberOfObjectsK = 3;
    public int numberOfObjectsJ = 2;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        bool LPress = Input.GetKeyDown(KeyCode.L);
        bool KPress = Input.GetKeyDown(KeyCode.K);
        bool JPress = Input.GetKeyDown(KeyCode.J);

        if (LPress == true)
        {
            
            Disparo_L();
           


        }

        if (KPress == true )
        {
            Disparo_K();

        }

        if (JPress == true )
        {
            Disparo_J();

        }

      

    }
    void Disparo_L()
    {
        for (int i = 0; i < numberOfObjectsL; i++)
        {
            Instantiate(Prefab_Bala, Torreta.position, transform.rotation);
            
        }
        

    }

    void Disparo_K()
    {
        for (int i = 0; i < numberOfObjectsK; i++)
        {
            Instantiate(Prefab_Bala, Torreta.position, transform.rotation);

        }
        

    }
    void Disparo_J()
    {
        for (int i = 0; i < numberOfObjectsJ; i++)
        {
            Instantiate(Prefab_Bala, Torreta.position, transform.rotation);

        }

    }
           

}
