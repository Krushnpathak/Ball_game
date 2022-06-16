﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Optionsmenu : MonoBehaviour
{
    public AudioMixer audiomixer;
    public GameObject Galaxy;
    public GameObject red;
    public GameObject mud;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;


    public void SetVolumeBG(float vol){
        audiomixer.SetFloat("BG",vol);
    }
    public void SetVolumeSFX(float vol1){
        audiomixer.SetFloat("SFX_Volume",vol1);
    }

    public void ChangeColor(int val){
        if(val == 0){
            red.SetActive(false);
            mud.SetActive(false);
            Galaxy.SetActive(true);
            camera1.SetActive(true);
            camera2.SetActive(false);
            camera3.SetActive(false);
        }
        else if(val == 1){
            Galaxy.SetActive(false);
            mud.SetActive(false);
            red.SetActive(true);
            camera1.SetActive(false);
            camera2.SetActive(true);
            camera3.SetActive(false);
        }
        else if(val == 2){
            Galaxy.SetActive(false);
            red.SetActive(false);
            mud.SetActive(true);
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
        }
    }

}