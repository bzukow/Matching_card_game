using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    private static MusicScript instance = null;
    public static MusicScript Instance
    {
        get { return instance; }
    }
   
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    /*Fairy Tale of Love by Martijn de Boer(NiGiD) 
    * (c) copyright 2018 Licensed under a Creative Commons Attribution Noncommercial(3.0) license.
    * http://dig.ccmixter.org/files/NiGiD/57348 Ft: Javolenus*/
}
