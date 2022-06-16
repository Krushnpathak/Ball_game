using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
            level_over();
        }
        ValueText.text = collectvalue.ToString();
    }

    void level_over(){
        Time.timeScale = 0f;
        LevelFinish.SetActive(true);
        // collectvalue = 0;
    }
}
