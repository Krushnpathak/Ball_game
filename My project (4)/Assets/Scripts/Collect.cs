using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public GameObject pickupeffect;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Pickup();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Pickup(){
        // Instantiate(pickupeffect,transform.position,transform.rotation);
        Destroy(gameObject);
    }
}
