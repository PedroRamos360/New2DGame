using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    [HideInInspector]
    public int player1damage = 0;
    public GameObject player1;
    [HideInInspector]
    public int player2damage = 0;
    public GameObject player2;

    private void Update() {
        if (player1damage >= 3)
            Destroy(player1);

        if (player2damage >= 3) {
            Destroy(player2);
        }
    }
}
