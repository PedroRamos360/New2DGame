using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    [HideInInspector]
    public int player1health = 100;
    public GameObject player1;
    [HideInInspector]
    public int player2health = 100;
    public GameObject player2;

    [HideInInspector]
    public bool player1dead = false;
    [HideInInspector]
    public bool player2dead = false;

    public GameObject VictoryMenu;

    private void Update() {
        if (player1health <= 0)
            Destroy(player1);
            player1dead = true;
            VictoryMenu.SetActive(true);

        if (player2health <= 0) {
            Destroy(player2);
            player2dead = true;
            VictoryMenu.SetActive(true);
        }
    }
}
