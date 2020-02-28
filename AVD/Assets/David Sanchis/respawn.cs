using UnityEngine;
 using System.Collections;
 
 public class respawn : MonoBehaviour {
     public float threshold;
 
     void FixedUpdate () {
        if (transform.position.y < threshold)
        {
            GetComponent<Rigidbody2D>().Sleep();
            transform.position = new Vector3(transform.position.x, 1.5f, transform.position.z);
            GetComponent<Rigidbody2D>().Sleep();
        }
     }
 }
