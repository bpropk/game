using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Vector3 myCamPos = Vector3.zero;
    void Start()
    {
        myCamPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        myCamPos.position = target.position + offset;
    }
}
