﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{

    public Boolean useNew;
    public int method;
    public int itemCount;
    public float ttl;
    public float spawnRate;

    static Settings instance;


    // Start is called before the first frame update
    void Start()
    {
        Settings.instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static Boolean isUseNew() {
        return Settings.instance.useNew;
    }

    public static int getMethodType()
    {
        return Settings.instance.method;
    }


    public static int getItemCount()
    {
        return Settings.instance.method;
    }

    public static float getTTL()
    {
        return Settings.instance.ttl;
    }

    public static float getSpawnRate()
    {
        return Settings.instance.spawnRate;

    }

}