using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VictoryText : MonoBehaviour {
    private TextMeshProUGUI victoryText;
    private PlayerDeath playerDeath;
    void Start() {
        playerDeath = FindObjectOfType<PlayerDeath>();
        victoryText = GetComponent<TextMeshProUGUI>();
    }

    void Update() {
        if (playerDeath.player1dead) {
            victoryText.text = FormatVictoryMessage(2);
        }
        if (playerDeath.player2dead) {
            victoryText.text = FormatVictoryMessage(1);
        }
    }

    private string FormatVictoryMessage(int playerNumber) {
        return $"PLAYER {playerNumber} WON";
    }
}
