﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathWaves : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;

    public GameObject loseMenu;
    public GameObject wavesMenu;

    PlayersHealth playersHealth;
    private bool healthP1Decreased = true;
    private bool healthP2Decreased = true;

    private void Start() {
        playersHealth = FindObjectOfType<PlayersHealth>();
    }
    private void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            if (gameObject == player1) {
                if (healthP1Decreased) {
                    Invoke("DecreaseP1Health", 0.3f);
                    healthP1Decreased = false;
                }    
            }

            if (gameObject == player2) {
                if (healthP2Decreased) {
                    Invoke("DecreaseP2Health", 0.3f);
                    healthP2Decreased = false;
                }
            }

        }
    }

    private void Update() {
        if (playersHealth.p1health <= 0) {
            Destroy(player1);
            Time.timeScale = 0;

            wavesMenu.SetActive(false);
            loseMenu.SetActive(true);
        }
        if (playersHealth.p2health <= 0) {
            Destroy(player2);
            Time.timeScale = 0;

            wavesMenu.SetActive(false);
            loseMenu.SetActive(true);
        }
    }

    private void DecreaseP1Health() {
        playersHealth.p1health -= 20;
        healthP1Decreased = true;
    }

    private void DecreaseP2Health() {
        playersHealth.p2health -= 20;
        healthP2Decreased = true;
    }
}
