using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanger : MonoBehaviour
{
    bool pause = false;
    public GameObject PauseMenu;
    public GameObject StartMenu;
    public GameObject UiSound;
    public GameObject OptionsMenu;
    public GameObject Levelselect;
    public GameObject LevelOverMenu;
    public GameObject LevelOverlay;
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

    public void QuitGame(){
        Application.Quit();
    }

    public void PlayUiSound(){
        UiSound.SetActive(false);
        UiSound.SetActive(true);
    }

    public void Options(){
        StartMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void back(){
        OptionsMenu.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void levelselect(){
        StartMenu.SetActive(false);
        Levelselect.SetActive(true);
    }

    public void LevelOver(){
        LevelOverlay.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // StartMenu.SetActive(true);
        // LevelOverMenu.SetActive(false);
    }

    public void Start_Game(){
        LevelOverlay.SetActive(true);
    }
}
