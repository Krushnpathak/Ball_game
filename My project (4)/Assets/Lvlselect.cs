using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvlselect : MonoBehaviour
{
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject StartMenu;
    public GameObject levelmenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play1(){
        lvl1.SetActive(true);
        lvl2.SetActive(false);
        lvl3.SetActive(false);
    }
    public void play2(){
        lvl1.SetActive(false);
        lvl2.SetActive(true);
        lvl3.SetActive(false);
    }

    public void play3(){
        lvl1.SetActive(false);
        lvl2.SetActive(false);
        lvl3.SetActive(true);
    }

    public void back(){
        StartMenu.SetActive(true);
        levelmenu.SetActive(false);
    }
}
