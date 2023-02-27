using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Boundary {
    public float xMin, xMax, zMin, zMax;
}


public class PlayerControl : MonoBehaviour
{
    public float speed;
    public Boundary bound;
    
    void FixedUpdate(){
        var hoz = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector3(hoz, 0, ver) * speed;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, bound.xMin, bound.xMax), 
            0,  
            Mathf.Clamp(transform.position.z, bound.zMin, bound.zMax)
        );
    }
}
