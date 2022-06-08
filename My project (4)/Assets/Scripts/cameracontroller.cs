using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    public GameObject follow;
    public float xoff,yoff,zoff;
    void Update()
    {
        transform.position = follow.transform.position + new Vector3(xoff,yoff,zoff);
        transform.LookAt(follow.transform.position);
    }
}
