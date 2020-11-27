using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthText : MonoBehaviour {
    public TextMeshProUGUI p1HealthText;
    public TextMeshProUGUI p2HealthText;
    PlayerDeath playerDeath;
    PlayerDeathWaves playerDeathWaves;
    bool pvpmode;


    private void Start() {
        pvpmode = SceneManager.GetActiveScene().name == "PVPMode";
        if (pvpmode) {
            playerDeath = FindObjectOfType<PlayerDeath>();
        } else {
            playerDeathWaves = FindObjectOfType<PlayerDeathWaves>();
        }
    }

    void Update() {
        if (pvpmode) {
            p1HealthText.text = playerDeath.player1health.ToString();
            p2HealthText.text = playerDeath.player2health.ToString();
        } else {
            Debug.Log(playerDeathWaves.player1health.ToString());
            p1HealthText.text = playerDeathWaves.player1health.ToString();
            p2HealthText.text = playerDeathWaves.player2health.ToString();
        }

    }
}
