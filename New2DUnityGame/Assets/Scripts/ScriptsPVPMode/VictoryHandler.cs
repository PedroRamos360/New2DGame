using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryHandler : MonoBehaviour {
    private TextMeshProUGUI victoryText;
    private PlayerDeath playerDeath;
    void Start() {
        playerDeath = FindObjectOfType<PlayerDeath>();
        victoryText = GetComponent<TextMeshProUGUI>();
    }

    void Update() {
        if (playerDeath.player1dead) {
            victoryText.text = FormatVictoryMessage(2);
            Invoke("NextRound", 1);
        }
        if (playerDeath.player2dead) {
            victoryText.text = FormatVictoryMessage(1);
            Invoke("NextRound", 1);
        }
    }

    private string FormatVictoryMessage(int playerNumber) {
        return $"PLAYER {playerNumber} WON";
    }

    private void NextRound() {
        SceneManager.LoadScene("PVPMode");
    }
}
