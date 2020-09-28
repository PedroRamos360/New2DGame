using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthText : MonoBehaviour {
    public TextMeshProUGUI p1HealthText;
    public TextMeshProUGUI p2HealthText;
    private PlayerDeath playerDeath;
    void Start() {
        playerDeath = FindObjectOfType<PlayerDeath>();
    }

    void Update() {
        p1HealthText.text = playerDeath.player1health.ToString();
        p2HealthText.text = playerDeath.player2health.ToString();
    }
}
