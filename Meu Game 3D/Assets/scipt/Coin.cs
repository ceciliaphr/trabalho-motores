using System;
using System.Security.Cryptography;
using UnityEngine;

public class Moeda1 : MonoBehaviour
{

    public int velocidadeGiro = 50;
    
    void start()
    {
    
    } 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            {
                Destroy(gameObject);
            }   
    }
    
    
    
    
    
    void update()
    {
        transform.Rotate(Vector3.up * velocidadeGiro * Time.deltaTime, Space.World);
    }
}   
    