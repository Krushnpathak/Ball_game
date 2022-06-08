using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float ms = 10f;
    private float xin;
    private float yin;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputs();
    }
    void FixedUpdate()
    {
        move();
    }

    private void inputs(){
        xin = Input.GetAxis("Horizontal");
        yin = Input.GetAxis("Vertical");
    }

    private void move(){
        rb.AddForce(new Vector3(xin,0f,yin)*ms);
    }
}
