using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    void FixedUpdate(){
        var hoz = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = new Vector3(hoz, 0, ver) * speed;
    }
}
