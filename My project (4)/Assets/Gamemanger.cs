using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanger : MonoBehaviour
{
    bool pause = false;
    public GameObject PauseMenu;
    public GameObject StartMenu;
    void Awake()
    {
        StartMenu.SetActive(true);
        pause = true;
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")){
            GamePause();
        }
    }
    
    public void GamePause(){
        if(pause == false){
            pause = true;
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }else{
            pause = false;
            PauseMenu.SetActive(false);
            StartMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
