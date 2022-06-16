using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroythis : MonoBehaviour
{
    void Awake(){
        GameObject[] musicobj = GameObject.FindGameObjectsWithTag("Music");
        if(musicobj.Length >1){
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
