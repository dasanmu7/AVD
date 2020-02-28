using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Collider2D other;
    public int puntos;
    bool activo = true;
   
    void OnTriggerEnter2D()
    {
        
        if (other.gameObject.CompareTag("Items") && activo)
        {
            activo = false;
            other.gameObject.SetActive(false);
             scoreScript.scoreValue += puntos;
        }
    }
}
