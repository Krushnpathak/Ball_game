using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectScore : MonoBehaviour
{
    public int collectvalue = 0;
    public Text ValueText;
    public GameObject LevelFinish;
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
        if(collectvalue >=5){
            Time.timeScale = 0f;
            LevelFinish.SetActive(true);
            collectvalue = 0;
        }
        ValueText.text = collectvalue.ToString();
    }
}
