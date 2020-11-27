using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathWaves : MonoBehaviour {
    [HideInInspector]
    public int player1health = 100;
    [HideInInspector]
    public int player2health = 100;

    public GameObject player1;
    public GameObject player2;


    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Enemy") {
            if (gameObject == player1) {
                player1health -= 20;
                Debug.Log(player1health);
            }

            if (gameObject == player2) {
                player2health -= 20;
                Debug.Log(player2health);
            }

        }
    }


    private void Update() {
        if (player1health <= 0) {
            Destroy(player1);
        }
        if (player2health <= 0) {
            Destroy(player2);
        }
    }
}
