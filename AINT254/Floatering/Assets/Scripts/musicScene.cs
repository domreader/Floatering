﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicScene : MonoBehaviour
{

    private AudioSource audioSource;
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();


     
       
    }
}
