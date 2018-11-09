﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour {

    public GameObject playerPrefab;
    GameObject playerInstance;

	// Use this for initialization
	void Start () {
        spawnPlayer();
	}
	
	// Update is called once per frame
	void Update () {
		if(playerInstance == null)
        {
            spawnPlayer();
        }
	}

    //spawns the player
    void spawnPlayer() {
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
}
