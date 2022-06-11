using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectScore : MonoBehaviour
{
    public int collectvalue = 0;
    public Text ValueText;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Collectible"){
            collectvalue++;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ValueText.text = collectvalue.ToString();
    }
}
