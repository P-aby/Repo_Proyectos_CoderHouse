using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public float Speed;
    public Vector3 Direccion;
    public int Damage;

    // Start is called before the first frame update
    void Start()
    {
        Speed = Random.Range(1.2f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Direccion * Speed * Time.deltaTime);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Muro")
        {
            Destroy(gameObject);
        }
    }


}

