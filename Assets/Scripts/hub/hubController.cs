﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hubController : MonoBehaviour
{

    public playerController playerStats;
    public int playerMoney;

    // Start is called before the first frame update
    void Start()
    {
        audioManager.playHUBMusic(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
